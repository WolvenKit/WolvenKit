using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Stop : questTimeDilation_Operation
	{
		[Ordinal(0)] [RED("easeOutCurve")] public CName EaseOutCurve { get; set; }

		public questTimeDilation_Stop(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
