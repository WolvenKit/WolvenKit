using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LcdScreenControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
		[Ordinal(104)] [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }
		[Ordinal(105)] [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(106)] [RED("messageRecordSelector")] public CHandle<ScreenMessageSelector> MessageRecordSelector { get; set; }

		public LcdScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
