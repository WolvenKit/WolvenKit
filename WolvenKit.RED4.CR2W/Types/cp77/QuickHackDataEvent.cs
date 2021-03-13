using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackDataEvent : redEvent
	{
		[Ordinal(0)] [RED("selectedData")] public CHandle<QuickhackData> SelectedData { get; set; }

		public QuickHackDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
