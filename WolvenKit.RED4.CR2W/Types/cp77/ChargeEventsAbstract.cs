using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargeEventsAbstract : WeaponEventsTransition
	{
		[Ordinal(0)] [RED("layerId")] public CUInt32 LayerId { get; set; }

		public ChargeEventsAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
