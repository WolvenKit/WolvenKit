using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetVideo : gameJournalInternetBase
	{
		private raRef<Bink> _videoResource;

		[Ordinal(4)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		public gameJournalInternetVideo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
