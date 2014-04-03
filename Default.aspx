<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NVC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <% //Initilize thr Progress Bar and show a message
        initNotify("Welcome to NVC Registration Application!");
        System.Threading.Thread.Sleep(2000);
    %>
    <div class="jumbotron">
        <h1>NVC REGISTRATION</h1>
        <p class="lead">NVC Registration is a tool for managing new and old students applications.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary ladda-button" data-style="expand-left">Learn more &raquo;</a></p>
     
    </div>

    <div class="row">
         <% 
            // We have achieved a milestone. Let the user know!
            Notify("30", "Loading Headers Completed ...");
            // Simulate Internet delay
           System.Threading.Thread.Sleep(300);
           
             %>
       <%--  <div class="col-md-4" style="background:#0cd426">
            <h2>New Applications</h2>
            <p>
                You have  new Application(s)
            </p>
            <p>
                <a class="btn btn-default" href="ImportApplications.aspx">Import Applications &raquo;</a>
            </p>
        </div>--%>
       
    <%--    <div class="col-md-4" style="background:#ffd800">
            <h2>Upcoming Course details</h2>
            <p>
                Course No:1000000
               Seats Available:1000
               Seats Remaining: 100 
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
       
        <div class="col-md-4">
            <h2>Teachers Profile</h2>
            <p>
                You can easily find teachers information here.
                Total no of teachers 100.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>

        <div class="widget-body">
                    <div class="row-fluid">
                      <div class="metro-nav">
                    <%--    <div class="metro-nav-block nav-block-orange">
                          <a href="#" data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info">692</div>
                            <div class="brand">Clients</div>
                          </a>
                        </div>--%>
                        <div class="metro-nav-block nav-block-green double">
                          <a href="#" data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info"><asp:Label ID="lblNo" runat="server" Font-Bold="true" Font-Underline="true">0</asp:Label></div>
                            <div class="brand">New Applications</div>
                          </a>
                        </div>
                           <% 
                                // We have achieved a milestone. Let the user know!
                                Notify("100", "Loading Apllication Count Completed ...");
                                // Simulate Internet dalay
                               System.Threading.Thread.Sleep(300);
           
             %>
                        <div class="metro-nav-block nav-block-blue">
                          <a href="#" data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info">1000</div>
                            <div class="brand">Upcoming Course</div>
                          </a>
                        </div>
                        <div class="metro-nav-block nav-block-yellow double">
                          <a href="~/Teachers?Designation=T" runat="server" data-original-title="">
                              <div class="fs1" aria-hidden="true" data-icon="">
                              </div>
                              <div class="info"><asp:Label runat="server" ID="lblTeachers"></asp:Label>
                              </div>
                            <div class="brand">Teachers</div>
                          </a>
                        </div>
                        <div class="metro-nav-block nav-block-orange">
                          <a href="~/Teachers?Designation=SAT" runat="server"  data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info"><asp:Label runat="server" ID="lblSat"></asp:Label></div>
                            <div class="brand">Sr. AT</div>
                          </a>
                        </div>
                       <div class="metro-nav-block nav-block-yellow">
                          <a href="~/Teachers?Designation=AT" runat="server" data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info"><asp:Label runat="server" ID="lblAt"></asp:Label></div>
                            <div class="brand">AT</div>
                          </a>
                        </div>
                           <div class="metro-nav-block nav-block-green">
                          <a href="~/Volunteers" runat="server"  data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info"><asp:Label runat="server" ID="lblVolunteers"></asp:Label></div>
                            <div class="brand">Volunteers</div>
                          </a>
                        </div>
                        <div class="metro-nav-block nav-block-blue">
                          <a href="~/ImportApplications" runat="server"  data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info"><asp:Label runat="server" ID="lblStudents"></asp:Label></div>
                            <div class="brand">Students</div>
                          </a>
                        </div>
                        <%-- <div class="metro-nav-block nav-block-green double">
                          <a href="#" data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info">$39432</div>
                            <div class="brand">Stock</div>
                          </a>
                        </div>
                        <div class="metro-nav-block nav-block-orange">
                          <a href="#" data-original-title="">
                            <div class="fs1" aria-hidden="true" data-icon=""></div>
                            <div class="info">434</div>
                            <div class="brand">Messages</div>
                          </a>
                        </div>
                       
                        --%>

                      </div>
                      
                    </div>
                  </div>
    </div>
      <%
            Notify("100", "Loading  Completed...");
          System.Threading.Thread.Sleep(100);
         %>
</asp:Content>
