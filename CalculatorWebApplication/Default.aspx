<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculatorWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .btnEqual {
            height: 26px;
        }
    </style>
    
</head>
<body style="margin:0px;width:400px; height:500px;">
    <form id="form1" runat="server">
         <table class="table_main">
            <tr>
                <td colspan="4" class="tdfirst"> <asp:Label ID="lbl_DisplayValue" runat="server" CssClass="lblDisplay" Text="0"></asp:Label></td>
            </tr>
             <!-- <tr>
                <td colspan="4" class="tdfirst"> <asp:Label ID="lbl_DisplayResult" runat="server" CssClass="lblDisplay" Text="0" Visible="false"></asp:Label></td>
            </tr> -->
            <tr>
                <td colspan="2"class="twocolums"  ><asp:Button ID="btn_Clear" runat="server" Text="C" CssClass="btnEqual" OnClick="btn_Clear_Click" /></td>
               <td colspan="2" class="twocolums" ><asp:Button ID="btn_Equals" runat="server" Text="=" CssClass="btnEqual" OnClick="btn_Equals_Click" /></td>
              
               
            </tr>
             <tr>
                <td><asp:Button ID="btn_Seven" runat="server" Text="7" CssClass="btn" OnClick="btn_Seven_Click" /></td>
               <td><asp:Button ID="btn_Eight" runat="server" Text="8" CssClass="btn" OnClick="btn_Eight_Click" /></td>
               <td><asp:Button ID="btn_Nine" runat="server" Text="9" CssClass="btn" OnClick="btn_Nine_Click" /></td>
                 <td><asp:Button ID="btn_Plus" runat="server" Text="+"  CssClass="btnOperator" OnClick="btn_Plus_Click"/></td>
               
            </tr>
              <tr>
                <td><asp:Button ID="btn_Four" runat="server" Text="4" CssClass="btn" OnClick="btn_Four_Click" /></td>
               <td><asp:Button ID="btn_Five" runat="server" Text="5"  CssClass="btn" OnClick="btn_Five_Click"/></td>
               <td><asp:Button ID="btn_Six" runat="server" Text="6"  CssClass="btn" OnClick="btn_Six_Click"/></td>
                 <td><asp:Button ID="btn_Minus" runat="server" Text="-"  CssClass="btnOperator" OnClick="btn_Minus_Click"/></td>
            </tr>
              <tr>
                <td><asp:Button ID="btn_One" runat="server" Text="1" CssClass="btn" OnClick="btn_One_Click" /></td>
               <td><asp:Button ID="btn_Two" runat="server" Text="2"  CssClass="btn" OnClick="btn_Two_Click"/></td>
               <td><asp:Button ID="btn_Three" runat="server" Text="3"  CssClass="btn" OnClick="btn_Three_Click"/></td>
                 <td><asp:Button ID="btn_Multi" runat="server" Text="*"  CssClass="btnOperator" OnClick="btn_Multi_Click"/></td>
                  
            </tr>
             <tr>
                 <td><asp:Button ID="btn_Dot" runat="server" Text="."  CssClass="btn" OnClick="btn_Dot_Click"/></td>
                
               <td><asp:Button ID="btn_Zero" runat="server" Text="0" CssClass="btn" OnClick="btn_Zero_Click" /></td>
               <td><asp:Button ID="btn_Percent" runat="server" Text="%"  CssClass="btnOperator" OnClick="btn_Percent_Click"/></td>
                 <td><asp:Button ID="btn_Division" runat="server" Text="/" CssClass="btnOperator" OnClick="btn_Division_Click" /></td>

                
            </tr>
            <tr>
                <td colspan="4"><asp:Label ID="lbl_PrevValue" runat="server" Visible="false" Text="#"></asp:Label>
                    <asp:Label ID="lbl_currentValue" runat="server" Visible="false" Text="#"></asp:Label>
                    <asp:Label ID="lbl_symbol" runat="server" Visible="false" Text="#"></asp:Label>
                </td>
            </tr>
        </table>
       
    </form>
</body>
</html>
