<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="UserViewBus.aspx.cs" Inherits="BusBookingSystem.UserViewBus" %>

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
                                    <h4>Bus Booking System</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="330px" height="200px" src="Images/Ticket.Png" />
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
                                <label>Bus ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Bus ID" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <h5>Passenger Details</h5>

                        <div class="row">
                            <div class="col-md-12">
                                <label>Full Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="Textboxtb2" runat="server"> </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ErrorMessage="Please Enter the Name" ControlToValidate="Textboxtb2"></asp:RequiredFieldValidator>

                                </div>
                                <label>User ID</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="Textbox25" runat="server"> </asp:TextBox>

                                </div>

                                <label>Age</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="Textboxt32" runat="server"></asp:TextBox>
                                </div>
                                <label>Contact Number</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Please Enter the Mobile Number" ControlToValidate="TextBox10"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Mobile Number length should be 10 in digit" ControlToValidate="TextBox10" ValidationExpression="\d{10}" ForeColor="Red"></asp:RegularExpressionValidator></td>
                                
                                </div>
                                <label>Email Id</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter the Email" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator25" runat="server" ForeColor="Red" ErrorMessage="Invalid Email Address" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>

                                </div>
                                <label>Number Of Tickets</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ErrorMessage="Please Enter the Mobile Number" ControlToValidate="TextBox10"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Mobile Number length should be 10 in digit" ControlToValidate="TextBox10" ValidationExpression="\d{10}" ForeColor="Red"></asp:RegularExpressionValidator></td>
                                
                                </div>

                                <label>Fare Amount</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox50" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <label>Total Amount</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <label>Payment Mode</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" Placeholder="Enter UPI ID"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-12">

                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Book Now" OnClick="Button1_Click" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-9">
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
                        <div runat="server">
                            <div class="row">
                                <div class="col">

                                    <asp:GridView ID="GridView1" class="table table-striped table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="BusId" DataSourceID="SqlDataSource1" Height="830px" Width="1070px">
                                        <Columns>
                                            <asp:BoundField DataField="BusId" HeaderText="BusId" ReadOnly="True" SortExpression="BusId" />
                                            <asp:BoundField DataField="BusName" HeaderText="BusName" SortExpression="BusName" />
                                            <asp:BoundField DataField="BusCategory" HeaderText="BusCategory" SortExpression="BusCategory" />
                                            <asp:BoundField DataField="Availability_Seats" HeaderText="Availability_Seats" SortExpression="Availability_Seats" />
                                            <asp:BoundField DataField="Boarding" HeaderText="Boarding" SortExpression="Boarding" />
                                            <asp:BoundField DataField="Departure" HeaderText="Departure" SortExpression="Departure" />
                                            <asp:BoundField DataField="StartTime" HeaderText="StartTime" SortExpression="StartTime" />
                                            <asp:BoundField DataField="EndTime" HeaderText="EndTime" SortExpression="EndTime" />
                                            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineBusBookingDbConnectionString2 %>" ProviderName="<%$ ConnectionStrings:OnlineBusBookingDbConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [BusInventory]"></asp:SqlDataSource>
                                    <br />

                                </div>
                                <br />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
