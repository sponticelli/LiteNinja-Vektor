using LiteNinja.Vektor.Meshes;
using UnityEngine;

namespace LiteNinja.Vektor.MeshFilters
{
  public class VectorMeshFilter : AVectorMeshFilter
  {
    [SerializeField] private Segment[] _segments;
    
    public Segment[] Segments
    {
      get => _segments;
      set => _segments = value;
    }
    protected override void GenerateMesh()
    {
      var vectorMesh = new VectorMesh(_segments, _lineWidth)
      {
        Join = _joinType
      };
      _meshFilter.mesh = vectorMesh.CreateMesh();
    }
  }
}