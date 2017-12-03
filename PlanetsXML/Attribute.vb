Partial Public Class planets

    Private planetField As planetsPlanet

    '''<remarks/>
    Public Property planet() As planetsPlanet
        Get
            Return Me.planetField
        End Get
        Set
            Me.planetField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanet

    Private xcoodField As planetsPlanetXcood

    Private ycoodField As planetsPlanetYcood

    Private idField As planetsPlanetID

    Private nameField As planetsPlanetName

    Private sysPosField As planetsPlanetSysPos

    Private spectralTypeField As planetsPlanetSpectralType

    Private spectralClassField As planetsPlanetSpectralClass

    Private subtypeField As planetsPlanetSubtype

    Private luminosityField As planetsPlanetLuminosity

    Private orbitRadiusField As planetsPlanetOrbitRadius

    Private orbitEccentricityField As planetsPlanetOrbitEccentricity

    Private orbitInclinationField As planetsPlanetOrbitInclination

    Private satelliteField As planetsPlanetSatellite

    Private gravityField As planetsPlanetGravity

    Private dayLengthField As planetsPlanetDayLength

    Private percentWaterField As planetsPlanetPercentWater

    Private volcanismField As planetsPlanetVolcanism

    Private tectonicsField As planetsPlanetTectonics

    Private landMassField() As planetsPlanetLandMass

    Private nadirChargeField As planetsPlanetNadirCharge

    Private zenithChargeField As planetsPlanetZenithCharge

    Private pressureField As planetsPlanetPressure

    Private pressureAtmField As planetsPlanetPressureAtm

    Private atmMassField As planetsPlanetAtmMass

    Private albedoField As planetsPlanetAlbedo

    Private greenhouseField As planetsPlanetGreenhouse

    Private temperatureField As planetsPlanetTemperature

    Private climateField As planetsPlanetClimate

    Private lifeFormField As planetsPlanetLifeForm

    Private habitabilityField As planetsPlanetHabitability

    Private popField As planetsPlanetPop

    Private governmentField As planetsPlanetGovernment

    Private controlRatingField As planetsPlanetControlRating

    Private socioIndustrialField As planetsPlanetSocioIndustrial

    Private hpgField As planetsPlanetHpg

    Private factionField As planetsPlanetFaction

    Private descField As String

    Private eventField() As planetsPlanetEvent

    '''<remarks/>
    Public Property xcood() As planetsPlanetXcood
        Get
            Return Me.xcoodField
        End Get
        Set
            Me.xcoodField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property ycood() As planetsPlanetYcood
        Get
            Return Me.ycoodField
        End Get
        Set
            Me.ycoodField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property id() As planetsPlanetID
        Get
            Return Me.idField
        End Get
        Set
            Me.idField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property name() As planetsPlanetName
        Get
            Return Me.nameField
        End Get
        Set
            Me.nameField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property sysPos() As planetsPlanetSysPos
        Get
            Return Me.sysPosField
        End Get
        Set
            Me.sysPosField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property spectralType() As planetsPlanetSpectralType
        Get
            Return Me.spectralTypeField
        End Get
        Set
            Me.spectralTypeField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property spectralClass() As planetsPlanetSpectralClass
        Get
            Return Me.spectralClassField
        End Get
        Set
            Me.spectralClassField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property subtype() As planetsPlanetSubtype
        Get
            Return Me.subtypeField
        End Get
        Set
            Me.subtypeField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property luminosity() As planetsPlanetLuminosity
        Get
            Return Me.luminosityField
        End Get
        Set
            Me.luminosityField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property orbitRadius() As planetsPlanetOrbitRadius
        Get
            Return Me.orbitRadiusField
        End Get
        Set
            Me.orbitRadiusField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property orbitEccentricity() As planetsPlanetOrbitEccentricity
        Get
            Return Me.orbitEccentricityField
        End Get
        Set
            Me.orbitEccentricityField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property orbitInclination() As planetsPlanetOrbitInclination
        Get
            Return Me.orbitInclinationField
        End Get
        Set
            Me.orbitInclinationField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property satellite() As planetsPlanetSatellite
        Get
            Return Me.satelliteField
        End Get
        Set
            Me.satelliteField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property gravity() As planetsPlanetGravity
        Get
            Return Me.gravityField
        End Get
        Set
            Me.gravityField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property dayLength() As planetsPlanetDayLength
        Get
            Return Me.dayLengthField
        End Get
        Set
            Me.dayLengthField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property percentWater() As planetsPlanetPercentWater
        Get
            Return Me.percentWaterField
        End Get
        Set
            Me.percentWaterField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property volcanism() As planetsPlanetVolcanism
        Get
            Return Me.volcanismField
        End Get
        Set
            Me.volcanismField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property tectonics() As planetsPlanetTectonics
        Get
            Return Me.tectonicsField
        End Get
        Set
            Me.tectonicsField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("landMass")>
    Public Property landMass() As planetsPlanetLandMass()
        Get
            Return Me.landMassField
        End Get
        Set
            Me.landMassField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property nadirCharge() As planetsPlanetNadirCharge
        Get
            Return Me.nadirChargeField
        End Get
        Set
            Me.nadirChargeField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property zenithCharge() As planetsPlanetZenithCharge
        Get
            Return Me.zenithChargeField
        End Get
        Set
            Me.zenithChargeField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property pressure() As planetsPlanetPressure
        Get
            Return Me.pressureField
        End Get
        Set
            Me.pressureField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property pressureAtm() As planetsPlanetPressureAtm
        Get
            Return Me.pressureAtmField
        End Get
        Set
            Me.pressureAtmField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property atmMass() As planetsPlanetAtmMass
        Get
            Return Me.atmMassField
        End Get
        Set
            Me.atmMassField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property albedo() As planetsPlanetAlbedo
        Get
            Return Me.albedoField
        End Get
        Set
            Me.albedoField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property greenhouse() As planetsPlanetGreenhouse
        Get
            Return Me.greenhouseField
        End Get
        Set
            Me.greenhouseField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property temperature() As planetsPlanetTemperature
        Get
            Return Me.temperatureField
        End Get
        Set
            Me.temperatureField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property climate() As planetsPlanetClimate
        Get
            Return Me.climateField
        End Get
        Set
            Me.climateField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property lifeForm() As planetsPlanetLifeForm
        Get
            Return Me.lifeFormField
        End Get
        Set
            Me.lifeFormField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property habitability() As planetsPlanetHabitability
        Get
            Return Me.habitabilityField
        End Get
        Set
            Me.habitabilityField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property pop() As planetsPlanetPop
        Get
            Return Me.popField
        End Get
        Set
            Me.popField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property government() As planetsPlanetGovernment
        Get
            Return Me.governmentField
        End Get
        Set
            Me.governmentField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property controlRating() As planetsPlanetControlRating
        Get
            Return Me.controlRatingField
        End Get
        Set
            Me.controlRatingField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property socioIndustrial() As planetsPlanetSocioIndustrial
        Get
            Return Me.socioIndustrialField
        End Get
        Set
            Me.socioIndustrialField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property hpg() As planetsPlanetHpg
        Get
            Return Me.hpgField
        End Get
        Set
            Me.hpgField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property faction() As planetsPlanetFaction
        Get
            Return Me.factionField
        End Get
        Set
            Me.factionField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property desc() As String
        Get
            Return Me.descField
        End Get
        Set
            Me.descField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("event")>
    Public Property [event]() As planetsPlanetEvent()
        Get
            Return Me.eventField
        End Get
        Set
            Me.eventField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetXcood

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetYcood

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetID

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetName

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetSysPos

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetSpectralType

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetSpectralClass

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetSubtype

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetLuminosity

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetOrbitRadius

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetOrbitEccentricity

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetOrbitInclination

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetSatellite

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetGravity

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetDayLength

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetPercentWater

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetVolcanism

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetTectonics

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetLandMass

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetNadirCharge

    Private isCanonField As Boolean

    Private valueField As Boolean

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Boolean
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetZenithCharge

    Private isCanonField As Boolean

    Private valueField As Boolean

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Boolean
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetPressure

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetPressureAtm

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetAtmMass

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetAlbedo

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetGreenhouse

    Private isCanonField As Boolean

    Private valueField As Decimal

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Decimal
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetTemperature

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetClimate

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetLifeForm

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetHabitability

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetPop

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetGovernment

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetControlRating

    Private isCanonField As Boolean

    Private valueField As Byte

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Byte
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetSocioIndustrial

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetHpg

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetFaction

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetEvent

    Private dateField As planetsPlanetEventDate

    Private factionField As planetsPlanetEventFaction

    '''<remarks/>
    Public Property [date]() As planetsPlanetEventDate
        Get
            Return Me.dateField
        End Get
        Set
            Me.dateField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property faction() As planetsPlanetEventFaction
        Get
            Return Me.factionField
        End Get
        Set
            Me.factionField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetEventDate

    Private isCanonField As Boolean

    Private valueField As Date

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute(DataType:="date")>
    Public Property Value() As Date
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class planetsPlanetEventFaction

    Private isCanonField As Boolean

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property isCanon() As Boolean
        Get
            Return Me.isCanonField
        End Get
        Set
            Me.isCanonField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set
            Me.valueField = Value
        End Set
    End Property
End Class
