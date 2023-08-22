using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRenderGameplayEffectsManagerSaveData : ISerializable
	{
		[Ordinal(0)] 
		[RED("cyberspacePixelsortParams")] 
		public gameCyberspacePixelsortEffectParams CyberspacePixelsortParams
		{
			get => GetPropertyValue<gameCyberspacePixelsortEffectParams>();
			set => SetPropertyValue<gameCyberspacePixelsortEffectParams>(value);
		}

		[Ordinal(1)] 
		[RED("cyberspacePixelsortEnabled")] 
		public CBool CyberspacePixelsortEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("enforceScreenSpaceReflectionsUberQuality")] 
		public CBool EnforceScreenSpaceReflectionsUberQuality
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameRenderGameplayEffectsManagerSaveData()
		{
			CyberspacePixelsortParams = new gameCyberspacePixelsortEffectParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
