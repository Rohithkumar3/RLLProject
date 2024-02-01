<%@ Page Title="" Language="C#" MasterPageFile="~/NonUserSite.Master" AutoEventWireup="true" CodeBehind="UnRegBusView.aspx.cs" Inherits="BusBookingSystem.UnRegBusView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 84px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BusId" DataSourceID="SqlDataSource1" CellPadding="4" CssClass="auto-style1" ForeColor="#333333" GridLines="None" Height="477px" Width="1369px">
        <AlternatingRowStyle BackColor="White" />
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
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineBusBookingDbConnectionString %>" ProviderName="<%$ ConnectionStrings:OnlineBusBookingDbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [BusInventory]"></asp:SqlDataSource>
    <br />
    <br />
    <center>
        <div class="col-2">

            <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Book Now" OnClick="Button1_Click" />

        </div>
    </center>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
