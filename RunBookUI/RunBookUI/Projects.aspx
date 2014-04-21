<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="RunBookUI.Projects" ViewStateMode="Disabled" %>

<%@ Register src="ProjectsList.ascx" tagname="ProjectsList" tagprefix="uc1" %>
<%@ Register src="ProjectsAddEdit.ascx" tagname="ProjectsAddEdit" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

        <uc1:ProjectsList ID="ProjectsList1" runat="server" />
        <uc2:ProjectsAddEdit ID="ProjectsAddEdit1" runat="server" />

    </form>
</body>
</html>
