using LiteNinja.Vektor.Meshes;
using UnityEngine;

namespace LiteNinja.Vektor.MeshFilters
{
  public class VectorConnectedMeshFilter : AVectorMeshFilter
  {
    [SerializeField] private Vector3[] _points;
    [SerializeField] private bool _isClosed;
    
    public Vector3[] Points
    {
      get => _points;
      set => _points = value;
    }
    
    public bool IsClosed
    {
      get => _isClosed;
      set => _isClosed = value;
    }
    
    
    protected override void GenerateMesh()
    {
      var vectorMesh = new VectorConnectedMesh(_points, _lineWidth)
      {
        Join = _joinType,
        IsClosed = _isClosed
      };
      _meshFilter.mesh = vectorMesh.CreateMesh();
    }
  }
}