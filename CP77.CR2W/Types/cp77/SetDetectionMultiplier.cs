using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetDetectionMultiplier : redEvent
	{
		[Ordinal(0)]  [RED("multiplier")] public CFloat Multiplier { get; set; }

		public SetDetectionMultiplier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
