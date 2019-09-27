<%@ Page Language="C#" Inherits="QnAAspTest.Index" Async=true %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Index</title>
</head>
<body>
	<form id="form1" runat="server">
            <label>Question</label>
            <input runat="server" id="txtquestion"/>
            
             <label>Answer</label>
            <input runat="server" id="txtanswer"/>
            
           
            
           <asp:Button runat="server" id="btncomplete" OnClick="btncomplete_clickAsync" Text="Complete List" />
            
            <label runat="server" id="txtresponse"></label>
	</form>
</body>
</html>
