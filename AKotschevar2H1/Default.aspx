<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AKotschevar2H1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-6">
            <h2>DateTime Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="1) DateTime.Now: "></asp:Label>
                <asp:TextBox ID="TextBox1AResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox1BResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="2) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox2AResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox2BResult" runat="server" Enabled="False"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="3)DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox3AResult" runat="server" Enabled="False" Width="40px"></asp:TextBox>
                <asp:TextBox ID="TextBox3BResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox3CResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label runat="server" Text="4) DateTime.AddDays(90): "></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False" Width="163px"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="5) DateTime.AddMonths(3): "></asp:Label>
                <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False" Width="163px"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="6) DateTime(Y, M, D): "></asp:Label>
                <asp:TextBox ID="TextBox6A" runat="server" Width="40px">2020</asp:TextBox>
                <asp:TextBox ID="TextBox6B" runat="server" Width="30px">11</asp:TextBox>
                <asp:TextBox ID="TextBox6C" runat="server" Width="30px">11</asp:TextBox>
                <asp:TextBox ID="TextBox6Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="7) DateTime.Parse(): "></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" Width="128px">October 31, 2020</asp:TextBox>
                <asp:TextBox ID="TextBox7Result" runat="server" Enabled="False" Width="140px"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="8) DateTime.TryParse: "></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" Width="127px">March 17, 1989</asp:TextBox>
                <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False" Width="122px"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="9) Date A - Date B: "></asp:Label>
                <asp:TextBox ID="TextBox9A" runat="server" Width="76px">03/01/2020</asp:TextBox>
                <asp:TextBox ID="TextBox9B" runat="server" Width="82px">02/14/2020</asp:TextBox>
                <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False" Width="119px"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="10) Date A &gt; Date B: "></asp:Label>
                <asp:TextBox ID="TextBox10A" runat="server" Width="71px">11/01/2020</asp:TextBox>
                <asp:TextBox ID="TextBox10B" runat="server" Width="76px">03/17/2020</asp:TextBox>
                <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group"></div>
            <asp:Button ID="DateCalculationsButton" runat="server" Text="Date Calculations" OnClick="DateCalculationsButton_Click1" />
        </div>
        <div class="col-md-6">
            <h2>String Methods</h2>   
             <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
            </div> <div class="form-group">
                <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
            </div>
            <p>
                &nbsp;</p>
        </div>
       
    </div>

</asp:Content>
