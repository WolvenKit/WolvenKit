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
			get
			{
				if (_windowBlindersSkillChecks == null)
				{
					_windowBlindersSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "windowBlindersSkillChecks", cr2w, this);
				}
				return _windowBlindersSkillChecks;
			}
			set
			{
				if (_windowBlindersSkillChecks == value)
				{
					return;
				}
				_windowBlindersSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("windowBlindersData")] 
		public WindowBlindersData WindowBlindersData
		{
			get
			{
				if (_windowBlindersData == null)
				{
					_windowBlindersData = (WindowBlindersData) CR2WTypeManager.Create("WindowBlindersData", "windowBlindersData", cr2w, this);
				}
				return _windowBlindersData;
			}
			set
			{
				if (_windowBlindersData == value)
				{
					return;
				}
				_windowBlindersData = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("cachedState")] 
		public CEnum<EWindowBlindersStates> CachedState
		{
			get
			{
				if (_cachedState == null)
				{
					_cachedState = (CEnum<EWindowBlindersStates>) CR2WTypeManager.Create("EWindowBlindersStates", "cachedState", cr2w, this);
				}
				return _cachedState;
			}
			set
			{
				if (_cachedState == value)
				{
					return;
				}
				_cachedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get
			{
				if (_alarmRaised == null)
				{
					_alarmRaised = (CBool) CR2WTypeManager.Create("Bool", "alarmRaised", cr2w, this);
				}
				return _alarmRaised;
			}
			set
			{
				if (_alarmRaised == value)
				{
					return;
				}
				_alarmRaised = value;
				PropertySet(this);
			}
		}

		public WindowBlindersControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
