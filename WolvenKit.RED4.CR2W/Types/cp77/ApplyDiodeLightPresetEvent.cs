using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDiodeLightPresetEvent : redEvent
	{
		[Ordinal(0)] [RED("preset")] public DiodeLightPreset Preset { get; set; }
		[Ordinal(1)] [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("force")] public CBool Force { get; set; }

		public ApplyDiodeLightPresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
