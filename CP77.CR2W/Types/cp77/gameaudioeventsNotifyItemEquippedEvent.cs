using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifyItemEquippedEvent : redEvent
	{
		[Ordinal(0)] [RED("itemName")] public CName ItemName { get; set; }

		public gameaudioeventsNotifyItemEquippedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
