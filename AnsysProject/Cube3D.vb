Imports System.Windows.Media
Imports System.Windows.Media.Media3D
Imports HelixToolkit.Wpf

Public Class Cube3D
    Public Function CreateWireframeCube(size As Double) As ModelVisual3D
        Dim cube As New ModelVisual3D()
        Dim edges As New LinesVisual3D With {
            .Thickness = 1,
            .Color = Colors.White
        }

        Dim p0 As New Point3D(0, 0, 0)
        Dim p1 As New Point3D(size, 0, 0)
        Dim p2 As New Point3D(size, size, 0)
        Dim p3 As New Point3D(0, size, 0)
        Dim p4 As New Point3D(0, 0, size)
        Dim p5 As New Point3D(size, 0, size)
        Dim p6 As New Point3D(size, size, size)
        Dim p7 As New Point3D(0, size, size)

        edges.Points.Add(p0)
        edges.Points.Add(p1)
        edges.Points.Add(p1)
        edges.Points.Add(p2)
        edges.Points.Add(p2)
        edges.Points.Add(p3)
        edges.Points.Add(p3)
        edges.Points.Add(p0)
        edges.Points.Add(p4)
        edges.Points.Add(p5)
        edges.Points.Add(p5)
        edges.Points.Add(p6)
        edges.Points.Add(p6)
        edges.Points.Add(p7)
        edges.Points.Add(p7)
        edges.Points.Add(p4)
        edges.Points.Add(p0)
        edges.Points.Add(p4)
        edges.Points.Add(p1)
        edges.Points.Add(p5)
        edges.Points.Add(p2)
        edges.Points.Add(p6)
        edges.Points.Add(p3)
        edges.Points.Add(p7)

        cube.Children.Add(edges)
        Return cube
    End Function
End Class
