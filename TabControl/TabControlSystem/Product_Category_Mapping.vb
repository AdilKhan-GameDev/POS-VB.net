'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Product_Category_Mapping
    Public Property Id As Integer
    Public Property ProductId As Integer
    Public Property CategoryId As Integer
    Public Property IsFeaturedProduct As Boolean
    Public Property DisplayOrder As Integer

    Public Overridable Property Category As Category
    Public Overridable Property Product As Product

End Class
