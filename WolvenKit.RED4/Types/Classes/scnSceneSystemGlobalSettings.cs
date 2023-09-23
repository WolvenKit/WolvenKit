using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class scnSceneSystemGlobalSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("syncLipsyncToSceneTime")] 
		public CBool SyncLipsyncToSceneTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnSceneSystemGlobalSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
