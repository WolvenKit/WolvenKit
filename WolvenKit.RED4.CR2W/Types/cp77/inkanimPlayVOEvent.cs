using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlayVOEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("VOLine")] public CString VOLine { get; set; }
		[Ordinal(2)] [RED("speakerName")] public CString SpeakerName { get; set; }

		public inkanimPlayVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
