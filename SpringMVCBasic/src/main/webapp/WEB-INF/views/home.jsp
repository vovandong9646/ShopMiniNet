<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@taglib prefix="spring" uri="http://www.springframework.org/tags" %>
<%@ page session="false"%>
<html>
<head>
<title>Home</title>
<%-- <link rel="stylesheet" type="text/css" href="<c:url value="/resources/css/theme-green.css"/> "> --%>
<link rel="stylesheet" href="<spring:theme code="style"/>" type="text/css"/>
</head>
<body>

	
	<h1><spring:message code="title" /></h1>

	<P>The time on the server is ${serverTime}.</P>

	<form action="/controller/users" method="post" modelAttribute="UserModel">
		<spring:message code="firstname" />:<br> <input type="text" name="firstname"/> <br> 
		<spring:message code="lastname" />:<br> <input type="text" name="lastname"/> <br>
		<spring:message code="age" />:<br> <input type="text" name="age"/> <br>
		<br> <input type="submit" value="Submit">
	</form>

</body>
</html>
