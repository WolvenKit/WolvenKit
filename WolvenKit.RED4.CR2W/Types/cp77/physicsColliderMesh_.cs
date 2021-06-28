using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderMesh_ : physicsICollider
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

		public physicsColliderMesh_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
