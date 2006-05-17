<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Nightly.aspx.cs" Inherits="Nightly" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script src="http://js.track.semway.com/v1.2/tag.js" type="text/javascript"></script>
    <script type="text/javascript">
    <!--
        swtag('scriptname=nightly', 'test=john');
    -->
    </script>

<h3>.netTier downloads</h3>

<b>official releases: </b><br/>
<ul>
<li><a href="files/nettiers beta 2.msi">.netTiers 0.9.2 [2005/22/11]</a></li></ul>

<b>NIGHTLY BUILDS :: .netTiers for .net 1.1 framework</b>
<ul>
<li>
    <asp:dropdownlist 
    id="DropDownList1" 
    runat="server" 
    datasourceid="ObjectDataSource1"
    datatextfield="Name" 
    datavaluefield="FileName"></asp:dropdownlist>
    <asp:Button ID="Button1" runat="server" Text="Download" OnClick="Button1_Click" />(date format: yyyy/mm/dd)
    </li></ul>

<b>NIGHTLY BUILDS :: .netTiers for .net 2.0 framework</b>
<ul>
<li>
 <asp:dropdownlist 
    id="DropDownList2" 
    runat="server" 
    datasourceid="ObjectDataSource2"
    datatextfield="Name" 
    datavaluefield="FileName"></asp:dropdownlist>
    <asp:Button ID="Button2" runat="server" Text="Download" OnClick="Button2_Click" /> (date format: yyyy/mm/dd)
    </li></ul>


			
			
			
<asp:objectdatasource id="ObjectDataSource1" runat="server" oldvaluesparameterformatstring="original_{0}"
        selectmethod="GetFiles" typename="NightlyHelper"><SelectParameters>
<asp:Parameter Type="String" DefaultValue="nettiers-fx1.1-*.zip" Name="mask"></asp:Parameter>
</SelectParameters>
</asp:objectdatasource>

<asp:objectdatasource id="ObjectDataSource2" runat="server" oldvaluesparameterformatstring="original_{0}"
        selectmethod="GetFiles" typename="NightlyHelper"><SelectParameters>
<asp:Parameter Type="String" DefaultValue="nettiers-fx2.0-*.zip" Name="mask"></asp:Parameter>
</SelectParameters>
</asp:objectdatasource>



</asp:Content>