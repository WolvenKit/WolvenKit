using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsColliderMesh : physicsICollider
	{
		private CArray<CName> _faceMaterials;
		private DataBuffer _compiledGeometryBuffer;

		[Ordinal(8)] 
		[RED("faceMaterials")] 
		public CArray<CName> FaceMaterials
		{
			get => GetProperty(ref _faceMaterials);
			set => SetProperty(ref _faceMaterials, value);
		}

		[Ordinal(9)] 
		[RED("compiledGeometryBuffer")] 
		public DataBuffer CompiledGeometryBuffer
		{
			get => GetProperty(ref _compiledGeometryBuffer);
			set => SetProperty(ref _compiledGeometryBuffer, value);
		}
	}
}
