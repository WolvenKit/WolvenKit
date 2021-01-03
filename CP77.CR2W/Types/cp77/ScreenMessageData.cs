using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScreenMessageData : IScriptable
	{
		[Ordinal(0)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(1)]  [RED("messageRecord")] public CHandle<gamedataScreenMessageData_Record> MessageRecord { get; set; }
		[Ordinal(2)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }

		public ScreenMessageData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
