'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Namespace Classes.Objects
    Public Class Units

#Region "Subs/Functions"
        Public Shared Function GetAllUnits()
            Return New List(Of Unit)({
                                     New Unit("BAGS", "BAG"),
                                     New Unit("BALE", "BAL"),
                                     New Unit("BUNDLES", "BDL"),
                                     New Unit("BUCKLES", "BKL"),
                                     New Unit("BILLIONS OF UNITS", "BOU"),
                                     New Unit("BOX", "BOX"),
                                     New Unit("BOTTLES", "BTL"),
                                     New Unit("BUNCHES", "BUN"),
                                     New Unit("CANS", "CAN"),
                                     New Unit("CUBIC METER", "CBM"),
                                     New Unit("CUBIC CENTIMETER", "CCM"),
                                     New Unit("CENTIMETER", "CMS"),
                                     New Unit("CARTONS", "CTN"),
                                     New Unit("DOZEN", "DOZ"),
                                     New Unit("DRUM", "DRM"),
                                     New Unit("GREAT GROSS", "GGR"),
                                     New Unit("GRAMS", "GMS"),
                                     New Unit("GROSS", "GRS"),
                                     New Unit("GROSS YARDS", "GYD"),
                                     New Unit("KILOGRAMS", "KGS"),
                                     New Unit("KILOLITER", "KLR"),
                                     New Unit("KILOMETRE", "KME"),
                                     New Unit("MILLILITRE", "MLT"),
                                     New Unit("METERS", "MTR"),
                                     New Unit("NUMBERS", "NOS"),
                                     New Unit("PACKS", "PAC"),
                                     New Unit("PIECES", "PCS"),
                                     New Unit("PAIRS", "PRS"),
                                     New Unit("QUINTAL", "QTL"),
                                     New Unit("ROLLS", "ROL"),
                                     New Unit("SETS", "SET"),
                                     New Unit("SQUARE FEET", "SQF"),
                                     New Unit("SQUARE METERS", "SQM"),
                                     New Unit("SQUARE YARDS", "SQY"),
                                     New Unit("TABLETS", "TBS"),
                                     New Unit("TEN GROSS", "TGM"),
                                     New Unit("THOUSANDS", "THD"),
                                     New Unit("TONNES", "TON"),
                                     New Unit("TUBES", "TUB"),
                                     New Unit("US GALLONS", "UGS"),
                                     New Unit("UNITS", "UNT"),
                                     New Unit("YARDS", "YDS"),
                                     New Unit("OTHERS", "OTH")
                                     }).ToArray
        End Function
#End Region

    End Class

    Public Class Unit

#Region "Fields/Properties"
        ReadOnly Property Name As String
        ReadOnly Property Symbol As String
#End Region

#Region "Constructors"
        Sub New()
            Me.Name = ""
            Me.Symbol = ""
        End Sub

        Sub New(ByVal Name As String, ByVal Symbol As String)
            Me.Name = Name
            Me.Symbol = Symbol
        End Sub
#End Region

#Region "Subs/Functions"
        Public Overrides Function ToString() As String
            Return Name
        End Function
#End Region

    End Class
End Namespace