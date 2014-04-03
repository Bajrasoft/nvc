<%@ Page Title="Teachers Detail" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="NVC.Teachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>  
    <div class="row">
      <div class="form-horizontal" style="margin-right:5px">
            <div class="col-md-8">
            <div style="clear:both">
              <h4 runat="server" id="lblGridTitle">Teachers List</h4>
              
             <asp:GridView runat="server" ID="gvTeachers"  GridLines="None"
           AutoGenerateColumns="true"
            CssClass="table table-striped table-hover"
            PagerStyle-CssClass="pgr"
            AlternatingRowStyle-CssClass="alt"></asp:GridView>

         </div>
          </div>
          </div>
        </div>

</asp:Content>
