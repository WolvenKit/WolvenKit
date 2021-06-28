using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmSetup : CVariable
	{
		private CBool _useSound;
		private CName _alarmSound;

		[Ordinal(0)] 
		[RED("useSound")] 
		public CBool UseSound
		{
			get => GetProperty(ref _useSound);
			set => SetProperty(ref _useSound, value);
		}

		[Ordinal(1)] 
		[RED("alarmSound")] 
		public CName AlarmSound
		{
			get => GetProperty(ref _alarmSound);
			set => SetProperty(ref _alarmSound, value);
		}

		public SecurityAlarmSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
