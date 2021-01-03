using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootIK : animAnimEvent
	{
		[Ordinal(0)]  [RED("leg")] public CEnum<animLeg> Leg { get; set; }

		public animAnimEvent_FootIK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
