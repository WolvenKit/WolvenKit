using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnScenesVersions : CResource
	{
		[Ordinal(1)] 
		[RED("currentVersion")] 
		public CUInt32 CurrentVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("scenesChanges")] 
		public CArray<scnScenesVersionsSceneChanges> ScenesChanges
		{
			get => GetPropertyValue<CArray<scnScenesVersionsSceneChanges>>();
			set => SetPropertyValue<CArray<scnScenesVersionsSceneChanges>>(value);
		}

		public scnScenesVersions()
		{
			ScenesChanges = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
