using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleParams : CVariable
	{
		private CName _visionTag;
		private CArray<gameMeshDef> _meshComponents;

		[Ordinal(0)] 
		[RED("visionTag")] 
		public CName VisionTag
		{
			get => GetProperty(ref _visionTag);
			set => SetProperty(ref _visionTag, value);
		}

		[Ordinal(1)] 
		[RED("meshComponents")] 
		public CArray<gameMeshDef> MeshComponents
		{
			get => GetProperty(ref _meshComponents);
			set => SetProperty(ref _meshComponents, value);
		}

		public gameVisionModuleParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
