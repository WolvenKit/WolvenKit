using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SharpeningAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("sharpeningStrength")] public CFloat SharpeningStrength { get; set; }

		public SharpeningAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
