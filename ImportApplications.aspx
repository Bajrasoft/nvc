<%@ Page Title="Manage Applications" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="ImportApplications.aspx.cs" Inherits="NVC.ImportApplications" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
  
     <div class="form-horizontal" style="margin-right:5px">
          
     <div class="form-group"> <h2><%: Title %>.
</h2>
          <div style="float:right;padding-left:15px;clear:both">
                <asp:Button runat="server" ID="Import" Text="Import Applications" CssClass="btn btn-primary btn-large" OnClick="Import_Click" OnClientClick="ShowLoading()" />
        </div>
         <div style="clear:both"></div>
         <div style="width:100%;float:right;text-align:center">

             <form > <button class="btn btn-primary ladda-button" data-style="expand-left"><span class="ladda-label">expand-left</span></button>
      <input type="text" class="form-control" style="display:inline" runat="server" id="txtSearch"  placeholder="Search">&nbsp;<asp:Button OnClick="btnSearch_Click"  runat="server" ID="btnSearch" Text="Search" CssClass="btn btn-primary ladda-button" data-style="expand-right" Height="37px" Style="vertical-align:top" />
    </form>
         </div>
         <div style="clear:both">
              <h4>Recent applcations.</h4>
              
             <asp:GridView runat="server" ID="gvApplication"  GridLines="None"
           AutoGenerateColumns="true"
            CssClass="table table-striped table-hover"
            PagerStyle-CssClass="pgr"
            AlternatingRowStyle-CssClass="alt"></asp:GridView>

         </div>
           
        </div>
        </div>
   <%-- <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>--%>
   <script>
       paceOptions = {
           elements: true
       };
           function load(time){
             var x = new XMLHttpRequest()
             x.open('GET', "http://localhost:5646/walter/" + time, true);
             x.send();
           };
       function ShowLoading()
       {
         
          // alert(1);
           Pace.restart();
           setTimeout("ShowLoading()", 100);
         
       }
   </script>
</asp:Content>
