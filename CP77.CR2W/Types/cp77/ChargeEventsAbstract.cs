using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChargeEventsAbstract : WeaponEventsTransition
	{
		[Ordinal(0)] [RED("layerId")] public CUInt32 LayerId { get; set; }

		public ChargeEventsAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
