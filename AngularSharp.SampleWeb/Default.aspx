<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AngularSharp.SampleWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="SinglePageApplication" ng-controller="MainController">
<head runat="server">
    <title>{{PageTitle}}</title>
    <link rel="stylesheet" href="/Styles/Mail.css" />
    <link rel="stylesheet" href="/Styles/Bootstrap/bootstrap.min.css" />
    <link rel="stylesheet" href="/Styles/Bootstrap/bootstrap-theme.min.css">
    <link ng-repeat="stylesheet in Stylesheets" rel="stylesheet" type="text/css" href="{{stylesheet.Source}}" />
</head>
<body>
    <form id="MainForm" runat="server">
        <ng-include src="{{ContentTemplateSource}}"></ng-include>
    </form>
    <script type="text/javascript" src="/Scripts/Bootstrap/bootstrap.min.js"></script>
    <script type="text/javascript" src="/Scripts/AngularJs/angular.min.js"></script>
    <script type="text/javascript" src="/Scripts/Main.js"></script>
    <script ng-repeat="script in Scripts" type="text/javascript" src="{{script.Source}}"></script>
</body>
</html>
