using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePendingSubtitles : CVariable
	{
		[Ordinal(0)]  [RED("pendingSubtitles")] public CArray<scnDialogLineData> PendingSubtitles { get; set; }

		public gamePendingSubtitles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
