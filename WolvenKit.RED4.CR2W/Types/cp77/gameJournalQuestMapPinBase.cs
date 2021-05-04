using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMapPinBase : gameJournalContainerEntry
	{
		private CBool _enableGPS;

		[Ordinal(2)] 
		[RED("enableGPS")] 
		public CBool EnableGPS
		{
			get => GetProperty(ref _enableGPS);
			set => SetProperty(ref _enableGPS, value);
		}

		public gameJournalQuestMapPinBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
