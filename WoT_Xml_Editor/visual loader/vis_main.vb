Imports System
Imports System.Collections.Generic
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Xml

Module vis_main
	Public xmldataset As New DataSet
	Public xml_name As String
	Public PackedFileName As String = ""
	Public ReadOnly sver As String = "0.5"
	Public ReadOnly stitle As String = "WoT Mod Tools "
	Public PS As New Packed_Section()
	Public PF As New Primitive_File()

	Public ReadOnly Binary_Header As Int32 = &H42A14E65
	Public filterlist() As String
	Public xDoc As XmlDocument
	Public Class myXmlTextWriter
		Inherits XmlTextWriter
		Public Overrides Sub WriteStartDocument()

		End Sub
		Public Sub New(sw As StringWriter)
			MyBase.New(sw)
		End Sub
	End Class
	Private Function fix_bad_tags(xmlString As String)
        'box all primitive tags.. Dont think there will ever be over 90 :-)
        xmlString = xmlString.Replace("<primitiveGroup> ", "<primitiveGroup>")
        For i = 90 To 0 Step -1
            Dim ast = xmlString.Replace("<primitiveGroup>" + i.ToString, "<primitiveGroup>" + ControlChars.CrLf.ToCharArray() + "<PG_ID>" + i.ToString + "</PG_ID>")
            xmlString = ast
        Next
        Return xmlString
	End Function

    Private Function PrettyPrint(XML As [String]) As [String]
        Dim Result As [String] = ""
        XML = fix_bad_tags(XML)
        'another hack to fix WG's bad xml
        XML = XML.Replace("<_", "<G_")
        XML = XML.Replace("</_", "</G_")
        Dim MS As New MemoryStream()

        XML = XML.Replace("rect1x4direction",
                          "rect1x4 direction")

        XML = XML.Replace("squaredirection",
                          "square direction")

        XML = XML.Replace("rightformfactor",
                          "right formfactor")

        XML = XML.Replace("rect1x3direction",
                          "rect1x3 direction")

        XML = XML.Replace("rect1x2direction",
                          "rect1x2 direction")

        XML = XML.Replace("rect1x6direction",
                          "rect1x6 direction")



        Dim xmlsettings As New XmlWriterSettings
        xmlsettings.Indent = True
        xmlsettings.NewLineOnAttributes = True
        xmlsettings.Encoding = Encoding.UTF8
        xmlsettings.OmitXmlDeclaration = True
        xmlsettings.CheckCharacters = True
        xmlsettings.CloseOutput = True
        Dim W = XmlWriter.Create(MS, xmlsettings)
        Dim D As New XmlDocument()
        Try
            ' Load the XmlDocument with the XML.
            D.LoadXml(XML)

            ' Write the XML into a formatting XmlTextWriter
            D.WriteContentTo(W)
            W.Flush()
            MS.Flush()

            ' Have to rewind the MemoryStream in order to read
            ' its contents.
            MS.Position = 0

            ' Read MemoryStream contents into a StreamReader.
            Dim SR As New StreamReader(MS)

            ' Extract the text from the StreamReader.
            Dim FormattedXML As [String] = SR.ReadToEnd()
            'MS.Close()
            'W.Close()

            Result = FormattedXML.Replace("<G_", "<_")
            Result = Result.Replace("</G_", "</_")

        Catch generatedExceptionName As XmlException
        End Try


        Return Result
    End Function

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by NRefactory.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

    Public Sub DecodePackedFile(ByVal reader As BinaryReader)
        reader.ReadSByte()

        Dim dictionary As List(Of String) = PS.readDictionary(reader)
        If IsNumeric(Left(PackedFileName, 1)) Then
        End If
        'because xml headers cant have numbers at the start.
        PackedFileName = "bad_" + PackedFileName
        Dim xmlroot As XmlNode = xDoc.CreateNode(XmlNodeType.Element, PackedFileName, "")
        'xDoc.OuterXml.Replace("><", ">" + vbCrLf + "<")
        PS.readElement(reader, xmlroot, xDoc, dictionary)
        Dim xml_string As String = xmlroot.InnerXml

        Dim strFilename As String = Temp_Storage + "\temp_xml.xml"
        File.WriteAllText(strFilename, "<" + PackedFileName + ">" + xml_string + "</" + PackedFileName + ">")

        xDoc.AppendChild(xmlroot)


        Dim f As String = File.ReadAllText(strFilename)
        f = f.Replace(">shared", "><shared>shared</shared>")
        File.Delete(strFilename)
        f = PrettyPrint(f)
        frmMain.fctb.Text = f.Replace("bad_", "")

        'f = f.Replace(vbCrLf, vbLf)

    End Sub

	Public Sub ReadPrimitiveFile(ByVal file As String)
		Dim F As New FileStream(file, FileMode.Open, FileAccess.Read)
		Dim reader As New BinaryReader(F)

		Dim ptiComment As XmlComment = xDoc.CreateComment("DO NOT SAVE THIS FILE! THIS CODE IS JUST FOR INFORMATION PUPORSES!")

		Dim xmlprimitives As XmlNode = xDoc.CreateNode(XmlNodeType.Element, "primitives", "")

		PF.ReadPrimitives(reader, xmlprimitives, xDoc)

		xDoc.AppendChild(ptiComment)
		xDoc.AppendChild(xmlprimitives)
		'frmMain.TxTOut.AppendText(FormatXml(xDoc.OuterXml))
		'Dim strFilename As String = System.IO.Path.GetTempFileName()
		'IO.File.WriteAllText(datapath + "\viewer_InnerXml.xml", PrettyXML(xDoc.OuterXml))


	End Sub

	Public Function openVisual(ByVal file As String) As Boolean
		xmldataset.Clear()
		While xmldataset.Tables.Count > 0
			xmldataset.Reset()
		End While
		xml_name = file + ".xml"
		xDoc = New XmlDocument()
		Dim ary = file.Split("\")
		Dim file2 = ary(ary.Length - 1)
		PackedFileName = file2
		PackedFileName = PackedFileName.ToLower()
		Dim f As FileStream

		Try
			f = New FileStream(file, FileMode.Open, FileAccess.Read)

		Catch ex As Exception
			MsgBox("can't find " + file + " file.." + vbCrLf + "This might crash this program!", MsgBoxStyle.Exclamation, "Bad news!")
			Return False
		End Try
		Dim reader As New BinaryReader(f)
		Dim head As Int32 = reader.ReadInt32()
		If head = Packed_Section.Packed_Header Then
			DecodePackedFile(reader)
		Else
			reader.Close()
			f.Close()
            Dim ff As String = PrettyPrint(IO.File.ReadAllText(file))
			frmMain.fctb.Text = ff
			Dim ar = file.Split("\")
			Dim ar2 = ar(ar.Length - 1).Split(".")
			Dim name = ar2(0)
			If IsNumeric(Left(name, 2)) Then
				ff = ff.Replace(name, "bad_" + name)
			Else
			End If


		End If
		reader.Close()
		f.Close()
		Return True
	End Function
	Public Function TransformXML(ByVal xmlString As String, ByVal xlsString As String) As MemoryStream
		Dim memStream As MemoryStream = Nothing
		Try
			' Create a xml-document from the sent-in xml-string
			Dim xmlDoc As New XmlDocument
			xmlDoc.LoadXml(xmlString)

			' Load the xls into another document
			Dim xslDoc As New XmlDocument
			xslDoc.LoadXml(xlsString)

			' Create a transformation
			Dim trans As New System.Xml.Xsl.XslCompiledTransform
			trans.Load(xslDoc)

			' Create a memory stream for output
			memStream = New MemoryStream()

			' Do the transformation according to the XSLT and save the result in our memory stream
			trans.Transform(xmlDoc, Nothing, memStream)
			memStream.Position = 0
		Catch ex As Exception
			Throw ex
		End Try

		Return memStream
	End Function


End Module


