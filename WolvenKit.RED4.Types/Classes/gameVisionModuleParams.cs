using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModuleParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("visionTag")] 
		public CName VisionTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("meshComponents")] 
		public CArray<gameMeshDef> MeshComponents
		{
			get => GetPropertyValue<CArray<gameMeshDef>>();
			set => SetPropertyValue<CArray<gameMeshDef>>(value);
		}

		public gameVisionModuleParams()
		{
			MeshComponents = new();
		}
	}
}
