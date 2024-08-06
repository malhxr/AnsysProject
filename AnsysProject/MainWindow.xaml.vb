Imports System.Windows
Imports System.Windows.Media.Media3D
Imports HelixToolkit.Wpf

Class MainWindow
    Public Sub New()
        InitializeComponent()
        LoadWireframeCube()
    End Sub

    Private Sub LoadWireframeCube()
        Dim cube As New Cube3D()
        Dim cubeModel As ModelVisual3D = cube.CreateWireframeCube(1)

        Viewport3D.Children.Add(cubeModel)
    End Sub
End Class
