<%@ Page Title="Álbum Youtube" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VideosYT.aspx.cs" Inherits="VideoAlbum.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
         <h3 align="center">URL YouTube. 
         </h3>
            </div>
    <div>
        <asp:TextBox runat="server" CssClass="form-control"  ID="url_video" Width="700px" Height="30px" align="left" ></asp:TextBox>
        <asp:Button runat="server" Text="send" OnClick="SendURL_Click" Height="36px" Width="86px"  />
</div>






    <div class="container row">
        <div class="table small">
            <asp:GridView runat="server" ID="videos"  AutoGenerateColumns="false"   HorizontalAlign="center" >
                <Columns>

<%--                       <asp:ImageField DataImageUrlField="imagen" HeaderText="Image" ></asp:ImageField>
                      
                    <asp:BoundField DataField="titulo" HeaderText="Title" />
                    <asp:BoundField DataField="url" HeaderText="Video" />

                    <asp:BoundField DataField="descripcion" HeaderText="Description" />--%>
                             <asp:TemplateField HeaderText="Video">
                        <ItemTemplate>
                                         <a data-toggle="modal" href="<%# "#"+  Eval("id").ToString()%>">
                                    <img src="<%#   Eval("imagen").ToString()%>"></img>
                                </a> 
                              <div class="modal fade" id="<%#   Eval("id").ToString()%>" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                    <div class="modal-dialog">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <button type="button" class="close" data-dismiss="modal">
                                                    <span aria-hidden="true">&times;</span><span class="sr-only">Cerrar</span>
                                                </button>
                                                <h4 class="modal-title" id="myModalLabel"><%#   Eval("titulo").ToString()%></h4>
                                            </div>
                                            <div class="modal-body">
                                                <div class="row" style="padding: 15px">
                                                    <iframe width="500" height="400" src="<%# "https://www.youtube.com/embed/" + Eval("url").ToString().Split(new string[] { "v=" }, StringSplitOptions.None)[1] %>" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                                                </div>
                                                <div class="row" style="padding: 15px">
                                                    <h>
                                                        <%#   Eval("descripcion").ToString()%>
                                                    </h>
                                                </div>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                      
                        </ItemTemplate>
                    </asp:TemplateField>
            <asp:BoundField DataField="titulo" HeaderText="Title" />
                </Columns>
            </asp:GridView>
 
        </div>
    </div>
</asp:Content>
