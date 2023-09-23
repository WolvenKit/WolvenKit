using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CacheStatusEffectFXEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("vfxToCache")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> VfxToCache
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>(value);
		}

		[Ordinal(1)] 
		[RED("sfxToCache")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> SfxToCache
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>(value);
		}

		public CacheStatusEffectFXEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
