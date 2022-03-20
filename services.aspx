<%@ Page Title="" Language="C#" MasterPageFile="~/clientMasterPage.master" AutoEventWireup="true" CodeFile="services.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!-- //mian-content-->
  <!-- /features -->
    <section class="banner-bottom py-lg-5 py-md-5 py-3" id="feature">
        <div class="container">
            <div class="inner-sec py-lg-5 py-3">
                <h2 class="tittle text-center"> Services</h2>
                <div class="row mt-lg-5 mt-md-4 mt-4">
                    <div class="col-lg-4 about-in text-center">
                        
                        <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                        <div class="card">
                         <div class="card-body">
                                <span class="fa fa-bus mb-4"></span>
                                <h5 class="card-title"><%# Eval("title") %></h5>
                                <p class="card-text"><%# Eval("descripion") %></p>
                            </div>
                        </div>
                        </ItemTemplate>
                        
                        </asp:Repeater>
                    </div>
                    
                </div>
            </div>
        </div>
    </section>
    <!-- //features -->
<!--/newsletter-->

</asp:Content>

