using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsAttitudeChangedEvent : redEvent
	{
		private wCHandle<gameAttitudeAgent> _otherAgent;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(0)] 
		[RED("otherAgent")] 
		public wCHandle<gameAttitudeAgent> OtherAgent
		{
			get => GetProperty(ref _otherAgent);
			set => SetProperty(ref _otherAgent, value);
		}

		[Ordinal(1)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		public gameeventsAttitudeChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
