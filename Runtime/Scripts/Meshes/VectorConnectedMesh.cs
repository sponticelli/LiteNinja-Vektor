using System;
using UnityEngine;

namespace LiteNinja.Vektor.Meshes
{
  public class VectorConnectedMesh : VectorMesh
  {
    public Vector3[] Points { get; set; }

    public bool IsClosed { get; set; }

    public VectorConnectedMesh()
    {
      Points = Array.Empty<Vector3>();
      _mesh = null;
    }
    
    public VectorConnectedMesh(Vector3[] points, float lineWidth)
    {
      Points = points;
      _lineWidth = lineWidth;
    }

    public override Mesh CreateMesh()
    {
      var pointCount = IsClosed ? Points.Length : Points.Length - 1;
      _segments = new Segment[pointCount];

      for (var i = 0; i < pointCount; i++)
      {
        _segments[i] = new Segment(Points[i], Points[(i + 1) % Points.Length]);
      }

      return base.CreateMesh();
    }

  }
}