using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRenderGameplayEffectsManagerSaveData : ISerializable
	{
		private gameCyberspacePixelsortEffectParams _cyberspacePixelsortParams;
		private CBool _cyberspacePixelsortEnabled;
		private CBool _enforceScreenSpaceReflectionsUberQuality;

		[Ordinal(0)] 
		[RED("cyberspacePixelsortParams")] 
		public gameCyberspacePixelsortEffectParams CyberspacePixelsortParams
		{
			get => GetProperty(ref _cyberspacePixelsortParams);
			set => SetProperty(ref _cyberspacePixelsortParams, value);
		}

		[Ordinal(1)] 
		[RED("cyberspacePixelsortEnabled")] 
		public CBool CyberspacePixelsortEnabled
		{
			get => GetProperty(ref _cyberspacePixelsortEnabled);
			set => SetProperty(ref _cyberspacePixelsortEnabled, value);
		}

		[Ordinal(2)] 
		[RED("enforceScreenSpaceReflectionsUberQuality")] 
		public CBool EnforceScreenSpaceReflectionsUberQuality
		{
			get => GetProperty(ref _enforceScreenSpaceReflectionsUberQuality);
			set => SetProperty(ref _enforceScreenSpaceReflectionsUberQuality, value);
		}
	}
}
