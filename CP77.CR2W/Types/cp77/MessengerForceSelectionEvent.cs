using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessengerForceSelectionEvent : redEvent
	{
		[Ordinal(0)]  [RED("hash")] public CInt32 Hash { get; set; }
		[Ordinal(1)]  [RED("selectionIndex")] public CInt32 SelectionIndex { get; set; }

		public MessengerForceSelectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
