using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePendingSubtitles : CVariable
	{
		[Ordinal(0)] [RED("pendingSubtitles")] public CArray<scnDialogLineData> PendingSubtitles { get; set; }

		public gamePendingSubtitles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
