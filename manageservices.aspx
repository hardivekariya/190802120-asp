﻿<%@ Page Title="" Language="C#" MasterPageFile="~/adminMasterPage.master" AutoEventWireup="true"  EnableEventValidation="false" CodeFile="manageservices.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


 <!--main content start-->
<section id="main-content">
	<section class="wrapper">
	<div class="form-w3layouts">
        <!-- page start-->
        <!-- page start-->
        <div class="row">
            <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            Manage services
                        </header>
                        <div class="panel-body">
                            <div class="position-center">
                            <div class="form-group">
                                    <label for="exampleInputEmail1">Title</label>
                                    <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Enter email"></asp:TextBox>
                                </div>
                                
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Descripion</label>
                                    
                                    <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Enter email" TextMode="MultiLine"></asp:TextBox>
                                </div>

                                <div class="checkbox">
                                    <label for="exampleInputEmail1">Status</label>     
                                   <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                RepeatDirection="Horizontal">
                                       <asp:ListItem Value="1">active</asp:ListItem>
                                       <asp:ListItem Value="0">deactive</asp:ListItem>
                              
                                   </asp:RadioButtonList>
                            
                            </div>

                              <div class="checkbox">
                                
                                <asp:Button ID="Button2" runat="server" Text="submit" class="btn btn-info" onclick="Button2_Click" 
                                    ></asp:Button>

                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>

                             
                                    
                               
                        </div>

                        <div class="checkbox">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField HeaderText="id">
                                    <ItemTemplate>
                                        <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("id") %>'></asp:Literal>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="title">
                                    <ItemTemplate>
                                        <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("title") %>'></asp:Literal>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="descripion">
                                    <ItemTemplate>
                                        <asp:Literal ID="Literal4" runat="server" Text='<%# Eval("descripion") %>'></asp:Literal>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="status">
                                    <ItemTemplate>
                                        <asp:Literal ID="Literal5" runat="server" Text='<%# Eval("status") %>'></asp:Literal>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="edit">
                                    <ItemTemplate>
                                        <asp:Button ID="Button3" runat="server" CommandArgument='<%# Eval("id") %>' 
                                            Text="edit" onclick="Button3_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="delete">
                                    <ItemTemplate>
                                        <asp:Button ID="Button4" runat="server" CommandArgument='<%# Eval("id") %>' 
                                            onclick="Button4_Click" Text="delete" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            </asp:GridView>
                            </div>
                                 </div>
                                    

                                
                              
                    </section>

            </div>

    </div>
    </div>
    </div>
</asp:Content>

