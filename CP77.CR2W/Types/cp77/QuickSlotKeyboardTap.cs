using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickSlotKeyboardTap : redEvent
	{
		[Ordinal(0)]  [RED("keyIndex")] public CInt32 KeyIndex { get; set; }

		public QuickSlotKeyboardTap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
