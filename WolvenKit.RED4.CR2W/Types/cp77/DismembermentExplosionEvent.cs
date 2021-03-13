using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentExplosionEvent : redEvent
	{
		[Ordinal(0)] [RED("epicentrum")] public Vector4 Epicentrum { get; set; }
		[Ordinal(1)] [RED("strength")] public CFloat Strength { get; set; }

		public DismembermentExplosionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
