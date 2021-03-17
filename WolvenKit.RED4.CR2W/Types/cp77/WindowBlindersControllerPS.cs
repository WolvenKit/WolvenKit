using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _windowBlindersSkillChecks;
		private WindowBlindersData _windowBlindersData;
		private CEnum<EWindowBlindersStates> _cachedState;
		private CBool _alarmRaised;

		[Ordinal(103)] 
		[RED("windowBlindersSkillChecks")] 
		public CHandle<EngDemoContainer> WindowBlindersSkillChecks
		{
			get => GetProperty(ref _windowBlindersSkillChecks);
			set => SetProperty(ref _windowBlindersSkillChecks, value);
		}

		[Ordinal(104)] 
		[RED("windowBlindersData")] 
		public WindowBlindersData WindowBlindersData
		{
			get => GetProperty(ref _windowBlindersData);
			set => SetProperty(ref _windowBlindersData, value);
		}

		[Ordinal(105)] 
		[RED("cachedState")] 
		public CEnum<EWindowBlindersStates> CachedState
		{
			get => GetProperty(ref _cachedState);
			set => SetProperty(ref _cachedState, value);
		}

		[Ordinal(106)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get => GetProperty(ref _alarmRaised);
			set => SetProperty(ref _alarmRaised, value);
		}

		public WindowBlindersControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
