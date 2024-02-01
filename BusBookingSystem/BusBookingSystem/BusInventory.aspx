<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="BusInventory.aspx.cs" Inherits="BusBookingSystem.BusInventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Bus Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="200px" src="Images/Bus%20Add.jpeg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Bus ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Bus ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary col-md-4" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Bus Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Bus Name"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Bus Category</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="Textboxtb2" runat="server" placeholder="Bus Category"> </asp:TextBox>
                                </div>
                                <label>Seat Availability</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="Textboxt32" runat="server" placeholder="Seat Availability"> </asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Boarding Point</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="Textboxb1" runat="server" placeholder="Boarding Point"></asp:TextBox>
                                </div>
                                <label>Departure</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="Textboxtb23" runat="server" placeholder="Departure"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Start Time</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Start Time"> </asp:TextBox>
                                </div>
                                <label>End Time</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="End Time"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <%-- <div class="col-md-4">
                    
                 </div>--%>
                            <div class="col-md-12">
                                <label>Ticket Price</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Ticket Price"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button2_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <a href="AdminHomePage.aspx"><< Back to Home</a><br>
                <br>
            </div>


            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Bus Inventory List</h4>
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
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server">
                                </asp:GridView>

                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

