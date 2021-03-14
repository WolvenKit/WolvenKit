using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoundSystemControllerPS : MasterControllerPS
	{
		private CInt32 _defaultAction;
		private CArray<SoundSystemSettings> _soundSystemSettings;
		private CHandle<ChangeMusicAction> _currentEvent;
		private CHandle<ChangeMusicAction> _cachedEvent;

		[Ordinal(104)] 
		[RED("defaultAction")] 
		public CInt32 DefaultAction
		{
			get
			{
				if (_defaultAction == null)
				{
					_defaultAction = (CInt32) CR2WTypeManager.Create("Int32", "defaultAction", cr2w, this);
				}
				return _defaultAction;
			}
			set
			{
				if (_defaultAction == value)
				{
					return;
				}
				_defaultAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("soundSystemSettings")] 
		public CArray<SoundSystemSettings> SoundSystemSettings
		{
			get
			{
				if (_soundSystemSettings == null)
				{
					_soundSystemSettings = (CArray<SoundSystemSettings>) CR2WTypeManager.Create("array:SoundSystemSettings", "soundSystemSettings", cr2w, this);
				}
				return _soundSystemSettings;
			}
			set
			{
				if (_soundSystemSettings == value)
				{
					return;
				}
				_soundSystemSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("currentEvent")] 
		public CHandle<ChangeMusicAction> CurrentEvent
		{
			get
			{
				if (_currentEvent == null)
				{
					_currentEvent = (CHandle<ChangeMusicAction>) CR2WTypeManager.Create("handle:ChangeMusicAction", "currentEvent", cr2w, this);
				}
				return _currentEvent;
			}
			set
			{
				if (_currentEvent == value)
				{
					return;
				}
				_currentEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("cachedEvent")] 
		public CHandle<ChangeMusicAction> CachedEvent
		{
			get
			{
				if (_cachedEvent == null)
				{
					_cachedEvent = (CHandle<ChangeMusicAction>) CR2WTypeManager.Create("handle:ChangeMusicAction", "cachedEvent", cr2w, this);
				}
				return _cachedEvent;
			}
			set
			{
				if (_cachedEvent == value)
				{
					return;
				}
				_cachedEvent = value;
				PropertySet(this);
			}
		}

		public SoundSystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
