Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Namespace WebRequestPost
    Public Class WebRequestPost

        Public Shared Sub Main()
            ' Create a request using a URL that can receive a post.
            'Dim request As WebRequest = WebRequest.Create("http://rainbowteam.pl:3414/test/analytics.php")
            Dim request As WebRequest = WebRequest.Create("http://s.grappl.io:3690/test/analytics.php")
            ' Set the Method property of the request to POST.
            request.Method = "POST"
            ' Create POST data and convert it to a byte array.
            Dim postData As String = "Changed CDKey to: " & My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\RainbowTeamPL\ProjectPonyville", "cdkey", "")
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            ' Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded"
            ' Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length
            ' Get the request stream.
            Dim dataStream As Stream = request.GetRequestStream()
            ' Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length)
            ' Close the Stream object.
            dataStream.Close()
            ' Get the response.
            Dim response As WebResponse = request.GetResponse()
            ' Display the status.
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            ' Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.
            Dim reader As New StreamReader(dataStream)
            ' Read the content.
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Display the content.
            Console.WriteLine(responseFromServer)
            ' Clean up the streams.
            reader.Close()
            dataStream.Close()
            response.Close()
        End Sub
    End Class
End Namespace