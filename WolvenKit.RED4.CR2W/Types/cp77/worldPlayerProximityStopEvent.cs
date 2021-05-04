using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPlayerProximityStopEvent : redEvent
	{
		private CName _profile;

		[Ordinal(0)] 
		[RED("profile")] 
		public CName Profile
		{
			get => GetProperty(ref _profile);
			set => SetProperty(ref _profile, value);
		}

		public worldPlayerProximityStopEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
