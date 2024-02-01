<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="HistoryDetails.aspx.cs" Inherits="BusBookingSystem.HistoryDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" class="table table-striped table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="TicketID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="BusID" HeaderText="BusID" SortExpression="BusID" />
            <asp:BoundField DataField="username" HeaderText="UserName" SortExpression="username" />
            <asp:BoundField DataField="TicketID" HeaderText="TicketID" ReadOnly="True" SortExpression="TicketID" />
            <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
            <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
            <asp:BoundField DataField="ContactNumber" HeaderText="ContactNumber" SortExpression="ContactNumber" />
            <asp:BoundField DataField="EmailID" HeaderText="EmailID" SortExpression="EmailID" />
            <asp:BoundField DataField="NumberOfTickets" HeaderText="NumberOfTickets" SortExpression="NumberOfTickets" />
            <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" SortExpression="TotalAmount" />
            <asp:BoundField DataField="Fare" HeaderText="Fare" SortExpression="Fare" />
            <asp:BoundField DataField="PaymentMode" HeaderText="PaymentMode" SortExpression="PaymentMode" />
            <asp:BoundField DataField="PaymentStatus" HeaderText="PaymentStatus" SortExpression="PaymentStatus" />
            <asp:BoundField DataField="TicketStatus" HeaderText="TicketStatus" SortExpression="TicketStatus" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineBusBookingDbConnectionString6 %>" ProviderName="<%$ ConnectionStrings:OnlineBusBookingDbConnectionString6.ProviderName %>" SelectCommand="SELECT * FROM [BusBookingDetails]"></asp:SqlDataSource>
   
</asp:Content>
