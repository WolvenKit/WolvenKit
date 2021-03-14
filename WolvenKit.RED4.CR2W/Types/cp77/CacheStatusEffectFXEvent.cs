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
			get
			{
				if (_vfxToCache == null)
				{
					_vfxToCache = (CArray<wCHandle<gamedataStatusEffectFX_Record>>) CR2WTypeManager.Create("array:whandle:gamedataStatusEffectFX_Record", "vfxToCache", cr2w, this);
				}
				return _vfxToCache;
			}
			set
			{
				if (_vfxToCache == value)
				{
					return;
				}
				_vfxToCache = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sfxToCache")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> SfxToCache
		{
			get
			{
				if (_sfxToCache == null)
				{
					_sfxToCache = (CArray<wCHandle<gamedataStatusEffectFX_Record>>) CR2WTypeManager.Create("array:whandle:gamedataStatusEffectFX_Record", "sfxToCache", cr2w, this);
				}
				return _sfxToCache;
			}
			set
			{
				if (_sfxToCache == value)
				{
					return;
				}
				_sfxToCache = value;
				PropertySet(this);
			}
		}

		public CacheStatusEffectFXEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
