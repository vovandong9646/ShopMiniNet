<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<h1>Demo Shopping Cart Using Map</h1>
	<table border="1">
		<tr>
			<td>Id</td>
			<td>Name</td>
			<td>Image</td>
			<td>Price</td>
			<td>Quantity</td>
			<td></td>
		</tr>
		<c:forEach items="${listProducts}" var="product">
			<tr>
				<td>${product.id }</td>
				<td>${product.name }</td>
				<td>${product.image }</td>
				<td>${product.price }</td>
				<td>${product.quantity }</td>
				<td>
					<a href="/CartSpring/cart/add/${product.id}">Add Card</a>
				</td>
			</tr>
		</c:forEach>
	</table>
</body>
</html>