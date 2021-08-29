using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheStatusEffectFXEvent : redEvent
	{
		private CArray<CWeakHandle<gamedataStatusEffectFX_Record>> _vfxToCache;
		private CArray<CWeakHandle<gamedataStatusEffectFX_Record>> _sfxToCache;

		[Ordinal(0)] 
		[RED("vfxToCache")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> VfxToCache
		{
			get => GetProperty(ref _vfxToCache);
			set => SetProperty(ref _vfxToCache, value);
		}

		[Ordinal(1)] 
		[RED("sfxToCache")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> SfxToCache
		{
			get => GetProperty(ref _sfxToCache);
			set => SetProperty(ref _sfxToCache, value);
		}
	}
}
