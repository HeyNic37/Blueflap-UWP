﻿#ExternalChecksum("C:\Users\Sâm\Documents\Visual Studio 2015\Projects\Blueflap\Blueflap\SearchFight.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "44490C5E0ADBD5EABA51A520D2AEB98B")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.Blueflap

    Partial Class SearchFight
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionid
            Case 1
                    Me.Page = CType(target, Global.Windows.UI.Xaml.Controls.Page)
#ExternalSource("..\..\..\SearchFight.xaml",8)
                AddHandler DirectCast(Me.Page, Global.Windows.UI.Xaml.Controls.Page).SizeChanged, AddressOf Me.Page_SizeChanged
#End ExternalSource
                    Exit Select
            Case 2
                    Me.OpenAnim = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 3
                    Me.AncreGauche = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 4
                    Me.AncreDroit = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 5
                    Me.AncrageShow = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 6
                    Me.AncrageHide = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 7
                    Me.AncreMilieu = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 8
                    Me.ShowSuggestions = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 9
                    Me.HideSuggestion = CType(target, Global.Windows.UI.Xaml.Media.Animation.Storyboard)
                    Exit Select
            Case 10
                    Me.Dragger = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 11
                    Me.DefaultThemeColor = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 12
                    Me.Fightbar = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 13
                    Me.W1 = CType(target, Global.Windows.UI.Xaml.Controls.WebView)
                    Exit Select
            Case 14
                    Me.W2 = CType(target, Global.Windows.UI.Xaml.Controls.WebView)
                    Exit Select
            Case 15
                    Me.rectangle = CType(target, Global.Windows.UI.Xaml.Shapes.Rectangle)
                    Exit Select
            Case 16
                    Me.button = CType(target, Global.Windows.UI.Xaml.Controls.Button)
#ExternalSource("..\..\..\SearchFight.xaml",394)
                AddHandler DirectCast(Me.button, Global.Windows.UI.Xaml.Controls.Button).Tapped, AddressOf Me.Button_Tapped
#End ExternalSource
                    Exit Select
            Case 17
                    Me.Suggest = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 18
                    Me.Resize = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 19
                    Me.grid = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 20
                    Me.DragEllipse = CType(target, Global.Windows.UI.Xaml.Shapes.Ellipse)
                    Exit Select
            Case 21
                    Me.SizeLeft = CType(target, Global.Windows.UI.Xaml.Controls.Button)
#ExternalSource("..\..\..\SearchFight.xaml",415)
                AddHandler DirectCast(Me.SizeLeft, Global.Windows.UI.Xaml.Controls.Button).Tapped, AddressOf Me.Button_Tapped_1
#End ExternalSource
                    Exit Select
            Case 22
                    Me.SizeRight = CType(target, Global.Windows.UI.Xaml.Controls.Button)
#ExternalSource("..\..\..\SearchFight.xaml",420)
                AddHandler DirectCast(Me.SizeRight, Global.Windows.UI.Xaml.Controls.Button).Tapped, AddressOf Me.Button_Tapped_2
#End ExternalSource
                    Exit Select
            Case 23
                    Me.DerniereRecherche = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 24
                    Me.AdressBox = CType(target, Global.Windows.UI.Xaml.Controls.TextBox)
                    Exit Select
            Case 25
                    Me.Window_Title = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 26
                    Me.FightBox1 = CType(target, Global.Windows.UI.Xaml.Controls.ComboBox)
#ExternalSource("..\..\..\SearchFight.xaml",338)
                AddHandler DirectCast(Me.FightBox1, Global.Windows.UI.Xaml.Controls.ComboBox).DropDownClosed, AddressOf Me.ComboBox_DropDownClosed
#End ExternalSource
                    Exit Select
            Case 27
                    Me.FightBox2 = CType(target, Global.Windows.UI.Xaml.Controls.ComboBox)
                    Exit Select
            Case 28
                    Me.Fight_Butt = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 29
                    Me.load = CType(target, Global.Windows.UI.Xaml.Controls.ProgressRing)
                    Exit Select
                    Case Else
                        Exit Select
            End Select
                Me._contentLoaded = true
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetBindingConnector(connectionId As Integer, target As Object) As Global.Windows.UI.Xaml.Markup.IComponentConnector Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2.GetBindingConnector
            Dim returnValue As Global.Windows.UI.Xaml.Markup.IComponentConnector = Nothing
            Return returnValue
        End Function
    End Class

End Namespace
