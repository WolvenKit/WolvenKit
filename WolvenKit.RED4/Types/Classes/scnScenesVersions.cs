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
		[RED("scenes")] 
		public CArray<scnScenesVersionsSceneChanges> Scenes
		{
			get => GetPropertyValue<CArray<scnScenesVersionsSceneChanges>>();
			set => SetPropertyValue<CArray<scnScenesVersionsSceneChanges>>(value);
		}

		public scnScenesVersions()
		{
			Scenes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
