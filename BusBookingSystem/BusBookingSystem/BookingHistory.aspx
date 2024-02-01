<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="BookingHistory.aspx.cs" Inherits="BusBookingSystem.BookingHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Bus Booking History</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <center>
                                <div class="col">
                                    <center>
                                        <img width="300px" height="200px" src="Images/Ticket.Png" />
                                    </center>
                                </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-12">
                                <label>User ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="UserBox" runat="server" placeholder="User ID"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />

                        <div class="row">
                            <div class="col-md-12">
                                <label>Ticket ID</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TicketIDBox" runat="server" placeholder="TicketID"> </asp:TextBox>

                                </div>

                                <br />
                                <div class="row">
                                    <div class="col-md-12">

                                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Booking History" OnClick="Button1_Click" />

                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-md-12">

                                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Ticket Cancellation" OnClick="Button2_Click" />
                                    </div>

                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-14">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Booking Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
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
