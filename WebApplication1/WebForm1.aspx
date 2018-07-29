<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="NumberRepeater" runat="server" OnItemDataBound="BeforeDisplayList">
          <HeaderTemplate>
              <table>
              <tr>
                 <th>&nbsp</th>
                 <th>0</th>
                 <th>1</th>
                 <th>2</th>
                 <th>3</th>
                 <th>4</th>
                 <th>5</th>
                 <th>6</th>
                 <th>7</th>
                 <th>8</th>
                 <th>9</th>
                 <th>10</th>
                 <th>11</th>
                 <th>12</th>
              </tr>
          </HeaderTemplate>
          <ItemTemplate>
              <td><asp:Label runat="server" ID="Label1" /></td>
          </ItemTemplate>
          <FooterTemplate>
              </table>
          </FooterTemplate>
        </asp:Repeater>
        
    </form>
    
    

</body>
    <script>

    </script>
</html>
