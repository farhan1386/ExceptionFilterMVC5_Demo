# Exception Filter in ASP.Net MVC5

# Introduction

This will explain you basic of exception filter in ASP.Net MVC. The HandleError attribute is used to display user-friendly error pages to the end users when there is an unhandled exception.

# What is exception filter in asp.net MVC?

Exception Filter in MVC Application is to handle any exceptions that occur during ASP.NET MVC Request processing pipeline. The ASP.NET MVC Framework provides one in-built attribute called HandleError which is basically used to handle the unhandled exception in MVC application.

Exception Filter: Exception filter is use to handle errors raised by either your controller actions or controller action results. You can also use exception filters to log errors. It implements the IExceptionFilter attribute. 

# What are the Limitations of HandleErrorAttribute in MVC?

* We cannot log the error anywhere using the built-in HandleError attribute.
* It is not possible to handle the exceptions raised outside the controllers. For example- we cannot handle the exception because of the invalid URL.
* Scenario-based Exception Handling is not possible. For example – display one error page when the request comes via AJAX and show a different error page when it comes via other than AJAX.


# IExceptionFilter Interface

| Method | Description |
| --- | --- |
| OnException(ExceptionContext) | Called when an exception occurs. |
	
  
# For more information please visit below article
https://www.c-sharpcorner.com/article/exception-filter-in-asp-net-mvc/
