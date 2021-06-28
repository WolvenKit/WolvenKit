using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRenderGameplayEffectsManagerSaveData : ISerializable
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

		public gameRenderGameplayEffectsManagerSaveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
