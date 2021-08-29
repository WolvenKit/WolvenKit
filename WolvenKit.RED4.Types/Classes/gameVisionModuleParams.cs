using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModuleParams : RedBaseClass
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
	}
}
