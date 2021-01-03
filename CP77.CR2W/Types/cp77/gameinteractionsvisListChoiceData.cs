using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceData : CVariable
	{
		[Ordinal(0)]  [RED("captionParts")] public gameinteractionsChoiceCaption CaptionParts { get; set; }
		[Ordinal(1)]  [RED("inputActionName")] public CName InputActionName { get; set; }
		[Ordinal(2)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(3)]  [RED("timeProvider")] public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }
		[Ordinal(4)]  [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }

		public gameinteractionsvisListChoiceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
