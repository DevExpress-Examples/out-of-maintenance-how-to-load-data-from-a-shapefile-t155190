Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace XtraMap_ShapefileDataAdapter
    Partial Public Class Form1
        Inherits Form

        Private Const filename As String = "../../Data/Countries.shp"

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a map and add it to the form.
            Dim map As New MapControl() With {.Dock = DockStyle.Fill}
            Me.Controls.Add(map)

            ' Create an adapter to load data from shapefile.
            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Dim adapter As New ShapefileDataAdapter() With {.FileUri = New Uri(baseUri, filename)}

            ' Create a vector items layer and it to the map.
            Dim vectorLayer As New VectorItemsLayer() With {.Data = adapter}
            map.Layers.Add(vectorLayer)
        End Sub
    End Class

End Namespace
