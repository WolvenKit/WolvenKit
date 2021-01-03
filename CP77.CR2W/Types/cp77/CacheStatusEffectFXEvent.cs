using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CacheStatusEffectFXEvent : redEvent
	{
		[Ordinal(0)]  [RED("sfxToCache")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> SfxToCache { get; set; }
		[Ordinal(1)]  [RED("vfxToCache")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> VfxToCache { get; set; }

		public CacheStatusEffectFXEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
