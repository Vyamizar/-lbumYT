using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoAlbum.Models;

namespace VideoAlbum
{
    public partial class Contact : Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            tabla();

        }

        void tabla()
        {
            SqlCommand cmd = new SqlCommand("tablaVideos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            videos.DataSource = dt;
            videos.DataBind();
            con.Close();



        }


        protected void BtnRead_Click(object sender, EventArgs e)
        {

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
          //  ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void SendURL_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var token = ConfigurationManager.AppSettings["TokenYY_API"];
                var url = url_video.Text;
                var idUrl = url.ToString().Split(new string[] { "v=" }, StringSplitOptions.None)[1];
                var apiYT = "https://www.googleapis.com/youtube/v3/videos?id=";
                var param1 = "&key=" + token;
                var param2 = "&part=snippet";
                var final_url = apiYT + idUrl + param1 + param2;

                var uri = client.BaseAddress = new Uri(final_url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage resp = client.GetAsync(uri).Result;
                var resultado = resp.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject(resultado);
                var descripcion = resultado.Split(new string[] { "description" }, StringSplitOptions.None);
                var title = descripcion[0].Split(new string[] { "title" }, StringSplitOptions.None)[1].Replace('"',' ').Replace(':',' ').Replace(',',' ').Trim();
                var imagen = descripcion[1].Split(new string[] { "url" }, StringSplitOptions.None)[1].Split(new string[] { "," }, StringSplitOptions.None)[0].Replace('"', ' ').Trim();
                var imagen2 = imagen.Substring(3, imagen.Length -3).Trim();
                var descr = descripcion[1].Split(new string[] { "thumbnails" }, StringSplitOptions.None)[0];
                var descr2 = descr.Substring(4, descr.Length - 16);
            
            SqlCommand cmd = new SqlCommand("inserta_url", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@url", SqlDbType.VarChar).Value = url_video.Text;
            cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = imagen2;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descr2;
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = title;
            cmd.ExecuteNonQuery();
            con.Close();
            }
            Response.Redirect("VideosYT.aspx");
        }


    }
}