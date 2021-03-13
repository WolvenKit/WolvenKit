using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeDiodeLightSettingsEvent : redEvent
	{
		[Ordinal(0)] [RED("colorValues")] public CArray<CInt32> ColorValues { get; set; }
		[Ordinal(1)] [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(2)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(3)] [RED("curve")] public CName Curve { get; set; }
		[Ordinal(4)] [RED("loop")] public CBool Loop { get; set; }

		public ChangeDiodeLightSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
