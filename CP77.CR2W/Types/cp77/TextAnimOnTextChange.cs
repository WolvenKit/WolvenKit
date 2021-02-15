using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TextAnimOnTextChange : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("textField")] public inkTextWidgetReference TextField { get; set; }
		[Ordinal(2)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(3)] [RED("BlinkAnim")] public CHandle<inkanimDefinition> BlinkAnim { get; set; }
		[Ordinal(4)] [RED("ScaleAnim")] public CHandle<inkanimDefinition> ScaleAnim { get; set; }
		[Ordinal(5)] [RED("bufferedValue")] public CString BufferedValue { get; set; }

		public TextAnimOnTextChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
