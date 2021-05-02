using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheStatusEffectFXEvent : redEvent
	{
		private CArray<wCHandle<gamedataStatusEffectFX_Record>> _vfxToCache;
		private CArray<wCHandle<gamedataStatusEffectFX_Record>> _sfxToCache;

		[Ordinal(0)] 
		[RED("vfxToCache")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> VfxToCache
		{
			get => GetProperty(ref _vfxToCache);
			set => SetProperty(ref _vfxToCache, value);
		}

		[Ordinal(1)] 
		[RED("sfxToCache")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> SfxToCache
		{
			get => GetProperty(ref _sfxToCache);
			set => SetProperty(ref _sfxToCache, value);
		}

		public CacheStatusEffectFXEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
