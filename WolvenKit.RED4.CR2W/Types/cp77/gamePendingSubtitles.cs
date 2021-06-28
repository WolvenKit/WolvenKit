using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePendingSubtitles : CVariable
	{
		private CArray<scnDialogLineData> _pendingSubtitles;

		[Ordinal(0)] 
		[RED("pendingSubtitles")] 
		public CArray<scnDialogLineData> PendingSubtitles
		{
			get => GetProperty(ref _pendingSubtitles);
			set => SetProperty(ref _pendingSubtitles, value);
		}

		public gamePendingSubtitles(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
