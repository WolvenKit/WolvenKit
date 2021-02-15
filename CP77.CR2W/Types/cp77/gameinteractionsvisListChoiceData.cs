using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceData : CVariable
	{
		[Ordinal(0)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(1)] [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }
		[Ordinal(2)] [RED("inputActionName")] public CName InputActionName { get; set; }
		[Ordinal(3)] [RED("captionParts")] public gameinteractionsChoiceCaption CaptionParts { get; set; }
		[Ordinal(4)] [RED("timeProvider")] public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }

		public gameinteractionsvisListChoiceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
