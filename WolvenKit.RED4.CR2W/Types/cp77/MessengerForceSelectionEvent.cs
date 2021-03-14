using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerForceSelectionEvent : redEvent
	{
		[Ordinal(0)] [RED("selectionIndex")] public CInt32 SelectionIndex { get; set; }
		[Ordinal(1)] [RED("hash")] public CInt32 Hash { get; set; }

		public MessengerForceSelectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
