using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LcdScreenControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(1)]  [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(2)]  [RED("messageRecordSelector")] public CHandle<ScreenMessageSelector> MessageRecordSelector { get; set; }
		[Ordinal(3)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }

		public LcdScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
