<%@ Page Title="" Language="C#" MasterPageFile="~/NonUserSite.Master" AutoEventWireup="true" CodeBehind="UserForgotPswrd.aspx.cs" Inherits="BusBookingSystem.UserForgotPswrd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="Images/generaluser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Forgot Password</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>User ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter username" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>

                                </div>

                                <label>Full Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Full Name" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>

                                </div>

                                <label>NewPassword</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="New Password" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter New Password " ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="
                                    At least onelowercase and oneupper case letter,special character,onenumber,8 characters length"
                                        ControlToValidate="TextBox3" ValidationExpression="^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                                <label>Re-enter Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Re-enter Password" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Re-enter the password" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Update Password" OnClick="Button1_Click" />
                                </div>
                                <div class="form-group">
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />


                    <a href="NonUserhomepage.aspx"><< Back to Home</a>





                </div>
            </div>

        </div>
    </div>
</asp:Content>
