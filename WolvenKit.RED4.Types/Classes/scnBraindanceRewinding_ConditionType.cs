using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnBraindanceRewinding_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] 
		[RED("speed")] 
		public CEnum<scnBraindanceSpeed> Speed
		{
			get => GetPropertyValue<CEnum<scnBraindanceSpeed>>();
			set => SetPropertyValue<CEnum<scnBraindanceSpeed>>(value);
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(2)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetPropertyValue<CEnum<scnSceneVersionCheck>>();
			set => SetPropertyValue<CEnum<scnSceneVersionCheck>>(value);
		}
	}
}
