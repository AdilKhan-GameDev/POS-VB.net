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

Partial Public Class ShoppingCartItem
    Public Property Id As Integer
    Public Property StoreId As Integer
    Public Property ShoppingCartTypeId As Integer
    Public Property CustomerId As Integer
    Public Property ProductId As Integer
    Public Property AttributesXml As String
    Public Property CustomerEnteredPrice As Decimal
    Public Property Quantity As Integer
    Public Property RentalStartDateUtc As Nullable(Of Date)
    Public Property RentalEndDateUtc As Nullable(Of Date)
    Public Property CreatedOnUtc As Date
    Public Property UpdatedOnUtc As Date

    Public Overridable Property Product As Product

End Class
