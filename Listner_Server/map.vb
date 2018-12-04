Imports System.Xml
Imports System.Text

Public Class map
    Dim street As String
    Dim city As String
    Dim state As String
    Dim zipcode As String
    
    Sub getinfo(ByVal ip As String)
        ListBox1.Items.Clear()

        Try
            Dim xmldoc As New XmlDocument
            Dim xmlnode As XmlNodeList
            Dim i As Integer
            xmldoc.Load("http://freegeoip.net/xml/" & ip)
            xmlnode = xmldoc.GetElementsByTagName("Response")
            For i = 0 To xmlnode.Count - 1
                'xmlnode(i).ChildNodes.Item(0).InnerText.Trim()

                xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                ListBox1.Items.Add("IP Address : " & xmlnode(i).ChildNodes.Item(0).InnerText.Trim)
                ListBox1.Items.Add("Country Code : " & xmlnode(i).ChildNodes.Item(1).InnerText.Trim)
                ListBox1.Items.Add("Name : " & xmlnode(i).ChildNodes.Item(2).InnerText.Trim)
                ListBox1.Items.Add("Region Code : " & xmlnode(i).ChildNodes.Item(3).InnerText.Trim)
                ListBox1.Items.Add("Region Name : " & xmlnode(i).ChildNodes.Item(4).InnerText.Trim)
                ListBox1.Items.Add("City : " & xmlnode(i).ChildNodes.Item(5).InnerText.Trim)
                ListBox1.Items.Add("Zip Code : " & xmlnode(i).ChildNodes.Item(6).InnerText.Trim)
                ListBox1.Items.Add("Latitude : " & xmlnode(i).ChildNodes.Item(7).InnerText.Trim)
                ListBox1.Items.Add("Longitude : " & xmlnode(i).ChildNodes.Item(8).InnerText.Trim)
                ListBox1.Items.Add("Metro Code : " & xmlnode(i).ChildNodes.Item(9).InnerText.Trim)
                city = xmlnode(i).ChildNodes.Item(5).InnerText.Trim
                state = xmlnode(i).ChildNodes.Item(2).InnerText.Trim
                zipcode = xmlnode(i).ChildNodes.Item(6).InnerText.Trim

            Next

        Catch ex As Exception
            MsgBox("Error Please Try Again")
        End Try
        addressmap("", city, state, zipcode)


    End Sub
    Sub addressmap(ByVal txtStreet As String, ByVal txtCity As String, ByVal txtState As String, ByVal txtZipCode As String)

        Try
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty

            Dim queryAddress As New StringBuilder()

            queryAddress.Append("https://www.google.de/maps?q=")

            ' build street part of query string
            If txtStreet <> String.Empty Then
                street = txtStreet.Replace(" ", "+")
                queryAddress.Append(street + "," & "+")
            End If

            ' build city part of query string
            If txtCity <> String.Empty Then
                city = txtCity.Replace(" ", "+")
                queryAddress.Append(city + "," & "+")
            End If

            ' build state part of query string
            If txtState <> String.Empty Then
                state = txtState.Replace(" ", "+")
                queryAddress.Append(state + "," & "+")
            End If

            ' build zip code part of query string
            If txtZipCode <> String.Empty Then
                zip = txtZipCode
                queryAddress.Append(zip)
            End If

            ' pass the url with the query string to web browser control
            WebBrowser1.Navigate(queryAddress.ToString())

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")

        End Try
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ProgressBar1.Maximum = e.MaximumProgress
        ProgressBar1.Value = e.CurrentProgress
    End Sub
End Class