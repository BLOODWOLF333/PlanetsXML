﻿Imports System.Xml.Serialization

<Serializable,
ComponentModel.DesignerCategory("planets"),
XmlType(AnonymousType:=True),
XmlRoot("planets", IsNullable:=False)>
Partial Public Class eventsPlanets

    <XmlElement("planet")>
    Public Property eventsPlanetArray() As eventsPlanet()

End Class

<Serializable,
ComponentModel.DesignerCategory("planet"),
XmlType(AnonymousType:=True),
XmlRoot("planet", IsNullable:=False)>
Partial Public Class eventsPlanet
    Implements IComparable

    Public Overloads Function CompareTo(ByVal obj As Object) As Integer _
        Implements IComparable.CompareTo

        If obj Is Nothing Then Return 1

        Dim otherPlanet As eventsPlanet = TryCast(obj, eventsPlanet)
        If otherPlanet IsNot Nothing Then
            Return Me.id.CompareTo(otherPlanet.id)
        Else
            Throw New ArgumentException("Object is not a Planet")
        End If
    End Function

    <XmlElement("id")>
    Public Property id() As String

    <XmlElement("event")>
    Public Property eventArray() As eventsEvent()

End Class

<Serializable,
ComponentModel.DesignerCategory("event"),
XmlType(AnonymousType:=True),
XmlRoot("event", IsNullable:=False)>
Partial Public Class eventsEvent
    Implements IComparable

    Public Overloads Function CompareTo(ByVal obj As Object) As Integer _
        Implements IComparable.CompareTo

        If obj Is Nothing Then Return 1

        Dim otherEvent As eventsEvent = TryCast(obj, eventsEvent)
        If otherEvent IsNot Nothing Then
            Return Me.[date].CompareTo(otherEvent.[date])
        Else
            Throw New ArgumentException("Object is not an Event")
        End If
    End Function

    <XmlElement("albedo")>
    Public Property albedo() As Single?

    Public Function ShouldSerializealbedo() As Boolean

        Return Not (albedo() Is Nothing)

    End Function

    <XmlElement("atmosphere")>
    Public Property atmosphere() As String

    Public Function ShouldSerializeatmosphere() As Boolean

        Return Not (atmosphere() Is Nothing)

    End Function

    <XmlElement(DataType:="date")>
    Public Property [date]() As Date

    <XmlElement("dayLength")>
    Public Property dayL() As Short?

    Public Function ShouldSerializedayL() As Boolean

        Return Not (dayL() Is Nothing)

    End Function

    <XmlElement("desc")>
    Public Property desc() As String

    Public Function ShouldSerializedesc() As Boolean

        Return Not (desc() Is Nothing)

    End Function

    <XmlElement("climate")>
    Public Property climate() As Short?

    Public Function ShouldSerializeclimate() As Boolean

        Return Not (climate() Is Nothing)

    End Function

    <XmlElement("faction")>
    Public Property faction() As String

    Public Function ShouldSerializefaction() As Boolean

        Return Not (faction() Is Nothing)

    End Function

    <XmlElement("greenhouse")>
    Public Property greenhouse() As Single?

    Public Function ShouldSerializegreenhouse() As Boolean

        Return Not (greenhouse() Is Nothing)

    End Function

    <XmlElement("hpg")>
    Public Property hpg() As String

    Public Function ShouldSerializehpg() As Boolean

        Return Not (hpg() Is Nothing)

    End Function

    <XmlElement("icon")>
    Public Property icon() As String

    Public Function ShouldSerializeicon() As Boolean

        Return Not (icon() Is Nothing)

    End Function

    <XmlElement("landMass")>
    Public Property landMassArray() As String()

    Public Function ShouldSerializelandMass() As Boolean

        Return Not (landMassArray() Is Nothing)

    End Function

    <XmlElement("lifeForm")>
    Public Property lifeForm() As String

    Public Function ShouldSerializelifeForm() As Boolean

        Return Not (lifeForm() Is Nothing)

    End Function

    <XmlElement("message")>
    Public Property message() As String

    Public Function ShouldSerializemessage() As Boolean

        Return Not (message() Is Nothing)

    End Function

    <XmlElement("nadirCharge")>
    Public Property nc() As Boolean?

    Public Function ShouldSerializenc() As Boolean

        Return Not (nc() Is Nothing)

    End Function

    <XmlElement("percentWater")>
    Public Property percentWater() As Short?

    Public Function ShouldSerializepercentWater() As Boolean

        Return Not (percentWater() Is Nothing)

    End Function

    <XmlElement("pop")>
    Public Property pop() As Short?

    Public Function ShouldSerializepop() As Boolean

        Return Not (pop() Is Nothing)

    End Function

    <XmlElement("pressure")>
    Public Property pressure() As Short?

    Public Function ShouldSerializepressure() As Boolean

        Return Not (pressure() Is Nothing)

    End Function

    <XmlElement("satellite")>
    Public Property satelliteArray() As String()

    Public Function ShouldSerializesatellite() As Boolean

        Return Not (satelliteArray() Is Nothing)

    End Function

    <XmlElement("socioIndustrial")>
    Public Property socioIndustrial() As String

    Public Function ShouldSerializesocioIndustrial() As Boolean

        Return Not (socioIndustrial() Is Nothing)

    End Function

    <XmlElement("temperature")>
    Public Property temperature() As Short?

    Public Function ShouldSerializetemperature() As Boolean

        Return Not (temperature() Is Nothing)

    End Function

    <XmlElement("tilt")>
    Public Property tilt() As Short?

    Public Function ShouldSerializetilt() As Boolean

        Return Not (tilt() Is Nothing)

    End Function

    <XmlElement("zenithCharge")>
    Public Property zc() As Boolean?

    Public Function ShouldSerializezc() As Boolean

        Return Not (zc() Is Nothing)

    End Function

End Class