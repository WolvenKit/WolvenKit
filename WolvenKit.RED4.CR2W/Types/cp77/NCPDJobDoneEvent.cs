using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NCPDJobDoneEvent : redEvent
	{
		private CInt32 _levelXPAwarded;
		private CInt32 _streetCredXPAwarded;

		[Ordinal(0)] 
		[RED("levelXPAwarded")] 
		public CInt32 LevelXPAwarded
		{
			get => GetProperty(ref _levelXPAwarded);
			set => SetProperty(ref _levelXPAwarded, value);
		}

		[Ordinal(1)] 
		[RED("streetCredXPAwarded")] 
		public CInt32 StreetCredXPAwarded
		{
			get => GetProperty(ref _streetCredXPAwarded);
			set => SetProperty(ref _streetCredXPAwarded, value);
		}

		public NCPDJobDoneEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
