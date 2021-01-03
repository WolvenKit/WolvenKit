using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopDialogLine : redEvent
	{
		[Ordinal(0)]  [RED("fadeOut")] public CFloat FadeOut { get; set; }
		[Ordinal(1)]  [RED("stringId")] public CRUID StringId { get; set; }

		public gameaudioeventsStopDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
