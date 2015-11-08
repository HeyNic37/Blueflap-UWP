﻿' Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
''' </summary>
Public NotInheritable Class SearchFight
    Inherits Page
    Public Sub New()
        Me.InitializeComponent()
        AddHandler Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested, AddressOf MainPage_BackRequested
    End Sub
    Private Sub MainPage_BackRequested(sender As Object, e As Windows.UI.Core.BackRequestedEventArgs)
        'On retourne à la page principale quand le bouton retour "physique" est pressé
        If Frame.CanGoBack Then
            e.Handled = True
            Frame.GoBack()
        End If
    End Sub
    Private Sub ComboBox_DropDownClosed(sender As Object, e As Object)
        Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings
        'Définit les valeurs du moteur de recherche pour le côté Gauche

        If FightBox1.SelectedIndex = 1 Then
            localSettings.Values("F1Text") = "QWANT"
        ElseIf FightBox1.SelectedIndex = 4 Then
            localSettings.Values("F1Text") = "GOOGLE"
        ElseIf FightBox1.SelectedIndex = 0 Then
            localSettings.Values("F1Text") = "BING"
        ElseIf FightBox1.SelectedIndex = 2 Then
            localSettings.Values("F1Text") = "DUCKDUCKGO"
        ElseIf FightBox1.SelectedIndex = 5 Then
            localSettings.Values("F1Text") = "QWANT WEB"
        ElseIf FightBox1.SelectedIndex = 3 Then
            localSettings.Values("F1Text") = "YAHOO"
        ElseIf FightBox1.SelectedIndex = 6 Then
            localSettings.Values("F1Text") = "ASK"
        ElseIf FightBox1.SelectedIndex = 7 Then
            localSettings.Values("F1Text") = "YOUTUBE"
        ElseIf FightBox1.SelectedIndex = 8 Then
            localSettings.Values("F1Text") = "DREAMVIDS"
        ElseIf FightBox1.SelectedIndex = 9 Then
            localSettings.Values("F1Text") = "DAILYMOTION"
        ElseIf FightBox1.SelectedIndex = 10 Then
            localSettings.Values("F1Text") = "WIKIPEDIA"
        ElseIf FightBox1.SelectedIndex = 11 Then
            localSettings.Values("F1Text") = "TWITTER"
            ' ElseIf FightBox1.SelectedIndex = 12 Then
            '     localSettings.Values("A1") = SearchEngine_1.Text
            '     localSettings.Values("A2") = SearchEngine_2.Text
            '     localSettings.Values("Cust1") = SearchEngine_1.Text
            '     localSettings.Values("Cust2") = SearchEngine_2.Text
        End If
        'If Settings_SearchEngine.SelectedIndex = 12 Then
        'localSettings.Values("Custom_SearchEngine") = True
        'SearchEngine_1.Visibility = Visibility.Visible
        'SearchEngine_2.Visibility = Visibility.Visible
        'searchengine3.Visibility = Visibility.Visible
        'SearchEngine_1.Text = localSettings.Values("Cust1")
        'SearchEngine_2.Text = localSettings.Values("Cust2")
        'Else
        'localSettings.Values("Custom_SearchEngine") = False
        'SearchEngine_1.Visibility = Visibility.Collapsed
        'SearchEngine_2.Visibility = Visibility.Collapsed
        'searchengine3.Visibility = Visibility.Collapsed
        'End If
    End Sub

    Private Sub FightBox2_DropDownClosed(sender As Object, e As Object) Handles FightBox2.DropDownClosed
        Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings
        'Définit les valeurs du moteur de recherche pour le côté Droit

        If FightBox2.SelectedIndex = 1 Then
            localSettings.Values("F2Text") = "QWANT"
        ElseIf FightBox2.SelectedIndex = 4 Then
            localSettings.Values("F2Text") = "GOOGLE"
        ElseIf FightBox2.SelectedIndex = 0 Then
            localSettings.Values("F2Text") = "BING"
        ElseIf FightBox2.SelectedIndex = 2 Then
            localSettings.Values("F2Text") = "DUCKDUCKGO"
        ElseIf FightBox2.SelectedIndex = 5 Then
            localSettings.Values("F2Text") = "QWANT WEB"
        ElseIf FightBox2.SelectedIndex = 3 Then
            localSettings.Values("F2Text") = "YAHOO"
        ElseIf FightBox2.SelectedIndex = 6 Then
            localSettings.Values("F2Text") = "ASK"
        ElseIf FightBox2.SelectedIndex = 7 Then
            localSettings.Values("F2Text") = "YOUTUBE"
        ElseIf FightBox2.SelectedIndex = 8 Then
            localSettings.Values("F2Text") = "DREAMVIDS"
        ElseIf FightBox2.SelectedIndex = 9 Then
            localSettings.Values("F2Text") = "DAILYMOTION"
        ElseIf FightBox2.SelectedIndex = 10 Then
            localSettings.Values("F2Text") = "WIKIPEDIA"
        ElseIf FightBox2.SelectedIndex = 11 Then
            localSettings.Values("F2Text") = "TWITTER"
            ' ElseIf FightBox1.SelectedIndex = 12 Then
            '     localSettings.Values("A1") = SearchEngine_1.Text
            '     localSettings.Values("A2") = SearchEngine_2.Text
            '     localSettings.Values("Cust1") = SearchEngine_1.Text
            '     localSettings.Values("Cust2") = SearchEngine_2.Text
        End If
        'If Settings_SearchEngine.SelectedIndex = 12 Then
        'localSettings.Values("Custom_SearchEngine") = True
        'SearchEngine_1.Visibility = Visibility.Visible
        'SearchEngine_2.Visibility = Visibility.Visible
        'searchengine3.Visibility = Visibility.Visible
        'SearchEngine_1.Text = localSettings.Values("Cust1")
        'SearchEngine_2.Text = localSettings.Values("Cust2")
        'Else
        'localSettings.Values("Custom_SearchEngine") = False
        'SearchEngine_1.Visibility = Visibility.Collapsed
        'SearchEngine_2.Visibility = Visibility.Collapsed
        'searchengine3.Visibility = Visibility.Collapsed
        'End If
    End Sub
    Private Sub Fight()
        'On lance la navigation simultannée des deux WebView

        Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings
        localSettings.Values("textboxe") = AdressBox.Text
        localSettings.Values("F2Index") = FightBox2.SelectedIndex
        localSettings.Values("F1Index") = FightBox1.SelectedIndex

        If localSettings.Values("F1Text") = "GOOGLE" Then
            W1.Navigate(New Uri("http://www.google.fr/search?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "BING" Then
            W1.Navigate(New Uri("http://www.bing.com/search?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "YAHOO" Then
            W1.Navigate(New Uri("http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "DUCKDUCKGO" Then
            W1.Navigate(New Uri("http://duckduckgo.com/?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "QWANT WEB" Then
            W1.Navigate(New Uri("http://www.qwant.com/?q=" + localSettings.Values("textboxe") + "&t=web"))

        ElseIf localSettings.Values("F1Text") = "QWANT" Then
            W1.Navigate(New Uri("http://www.qwant.com/?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "ASK" Then
            W1.Navigate(New Uri("http://fr.ask.com/web?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "YOUTUBE" Then
            W1.Navigate(New Uri("http://www.youtube.com/results?search_query=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "DAILYMOTION" Then
            W1.Navigate(New Uri("http://www.dailymotion.com/fr/relevance/universal/search/" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "DREAMVIDS" Then
            W1.Navigate(New Uri("http://dreamvids.fr/search/&q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "WIKIPEDIA" Then
            W1.Navigate(New Uri("http://fr.wikipedia.org/w/index.php?search=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F1Text") = "TWITTER" Then
            W1.Navigate(New Uri("http://twitter.com/search?q=" + localSettings.Values("textboxe")))
        End If



        If localSettings.Values("F2Text") = "GOOGLE" Then
            W2.Navigate(New Uri("http://www.google.fr/search?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "BING" Then
            W2.Navigate(New Uri("http://www.bing.com/search?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "YAHOO" Then
            W2.Navigate(New Uri("http://fr.search.yahoo.com/search;_ylt=Ai38ykBDWJSAxF25NrTnjXxNhJp4?p=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "DUCKDUCKGO" Then
            W2.Navigate(New Uri("http://duckduckgo.com/?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "QWANT WEB" Then
            W2.Navigate(New Uri("http://www.qwant.com/?q=" + localSettings.Values("textboxe") + "&t=web"))

        ElseIf localSettings.Values("F2Text") = "QWANT" Then
            W2.Navigate(New Uri("http://www.qwant.com/?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "ASK" Then
            W2.Navigate(New Uri("http://fr.ask.com/web?q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "YOUTUBE" Then
            W2.Navigate(New Uri("http://www.youtube.com/results?search_query=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "DAILYMOTION" Then
            W2.Navigate(New Uri("http://www.dailymotion.com/fr/relevance/universal/search/" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "DREAMVIDS" Then
            W2.Navigate(New Uri("http://dreamvids.fr/search/&q=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "WIKIPEDIA" Then
            W2.Navigate(New Uri("http://fr.wikipedia.org/w/index.php?search=" + localSettings.Values("textboxe")))

        ElseIf localSettings.Values("F2Text") = "TWITTER" Then
            W2.Navigate(New Uri("http://twitter.com/search?q=" + localSettings.Values("textboxe")))
        End If

        'Incrémentation des statistiques concernant SearchFight dans les paramètres de Blueflap
        Try
            localSettings.Values("Stat2") = localSettings.Values("Stat2") + 1
        Catch
            localSettings.Values("Stat2") = 1
        End Try

        'Affichage des petites billes de chargement
        localSettings.Values("Loaded1") = "Chargement"
        localSettings.Values("Loaded2") = "Chargement"
        load.IsActive = True
    End Sub
    Private Sub AdressBox_KeyDown(sender As Object, e As KeyRoutedEventArgs) Handles AdressBox.KeyDown
        'Lance un combat en appuyant sur la touche ENTREE dans la textbox
        If (e.Key = Windows.System.VirtualKey.Enter) Then
            Fight()
        End If
    End Sub

    Private Sub Page_SizeChanged(sender As Object, e As SizeChangedEventArgs)
        'Pour que chaque Webview prenne la moitié de la fenêtre
        W1.Width = (Page.ActualWidth / 2) - 2
        W2.Width = (Page.ActualWidth / 2) - 2
    End Sub

    Private Sub Page_Loaded_1(sender As Object, e As RoutedEventArgs) Handles Page.Loaded
        'Là on a tout ce qui concerne l'initialisation de Blueflap : thème, valeurs des combobox, animation d'arrivée...
        OpenAnim.Begin()
        W1.Width = (Page.ActualWidth / 2) - 2
        W2.Width = (Page.ActualWidth / 2) - 2
        W1.Navigate(New Uri("about:blank"))
        W2.Navigate(New Uri("about:blank"))

        Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings

        Try
            FightBox1.SelectedIndex = localSettings.Values("F1Index")
            FightBox2.SelectedIndex = localSettings.Values("F2Index")
            AdressBox.Text = localSettings.Values("textboxe")
        Catch
            FightBox1.SelectedIndex = 0
            FightBox2.SelectedIndex = 1
        End Try

        If localSettings.Values("DarkThemeEnabled") = True Then 'Theme Sombre

            Fightbar.RequestedTheme = ElementTheme.Dark
            Fightbar.Background = New SolidColorBrush(Windows.UI.Color.FromArgb(255, 27, 27, 27))
            Window_Title.Opacity = 100
            Window_Title.Foreground = New SolidColorBrush(Windows.UI.Color.FromArgb(255, 187, 187, 187))
        Else 'Theme Clair

            Fightbar.RequestedTheme = ElementTheme.Light
        End If

        Try
            If localSettings.Values("CustomColorEnabled") = True Then
                button.Background = New SolidColorBrush(Windows.UI.Color.FromArgb(localSettings.Values("CustomColorD"), localSettings.Values("CustomColorA"), localSettings.Values("CustomColorB"), localSettings.Values("CustomColorC")))
                Fight_Butt.Background = New SolidColorBrush(Windows.UI.Color.FromArgb(localSettings.Values("CustomColorD"), localSettings.Values("CustomColorA"), localSettings.Values("CustomColorB"), localSettings.Values("CustomColorC")))
                rectangle.Fill = New SolidColorBrush(Windows.UI.Color.FromArgb(localSettings.Values("CustomColorD"), localSettings.Values("CustomColorA"), localSettings.Values("CustomColorB"), localSettings.Values("CustomColorC")))
            Else
                button.Background = DefaultThemeColor.Background
                Fight_Butt.Background = DefaultThemeColor.Background
                rectangle.Fill = DefaultThemeColor.Background
            End If
        Catch
        End Try

    End Sub

    Private Sub Fight_Butt_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles Fight_Butt.Tapped
        'Cette fois on lance le combar en appuyant sur un bouton rechercher
        Fight()
    End Sub

    Private Sub Button_Tapped(sender As Object, e As TappedRoutedEventArgs)
        'Retour à la page précédente avec appui sur le bouton Back
        If Frame.CanGoBack Then
            Frame.GoBack()
        End If
    End Sub

    Private Sub W1_NavigationCompleted(sender As WebView, args As WebViewNavigationCompletedEventArgs) Handles W1.NavigationCompleted
        'On affiche ou non les petites billes de chargement
        Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings
        localSettings.Values("Loaded1") = "Chargé"
        If localSettings.Values("Loaded2") = "Chargé" Then
            load.IsActive = False
        End If
    End Sub

    Private Sub W2_NavigationCompleted(sender As WebView, args As WebViewNavigationCompletedEventArgs) Handles W2.NavigationCompleted
        'On affiche ou non les petites billes de chargement
        Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings
        localSettings.Values("Loaded2") = "Chargé"
        If localSettings.Values("Loaded1") = "Chargé" Then
            load.IsActive = False
        End If
    End Sub
End Class