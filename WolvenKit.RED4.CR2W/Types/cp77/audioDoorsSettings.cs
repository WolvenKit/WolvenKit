using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDoorsSettings : audioDeviceSettings
	{
		private CName _openEvent;
		private CName _openFailedEvent;
		private CName _closeEvent;
		private CName _lockEvent;
		private CName _unlockEvent;
		private CName _sealEvent;
		private CName _soundBank;

		[Ordinal(7)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get
			{
				if (_openEvent == null)
				{
					_openEvent = (CName) CR2WTypeManager.Create("CName", "openEvent", cr2w, this);
				}
				return _openEvent;
			}
			set
			{
				if (_openEvent == value)
				{
					return;
				}
				_openEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("openFailedEvent")] 
		public CName OpenFailedEvent
		{
			get
			{
				if (_openFailedEvent == null)
				{
					_openFailedEvent = (CName) CR2WTypeManager.Create("CName", "openFailedEvent", cr2w, this);
				}
				return _openFailedEvent;
			}
			set
			{
				if (_openFailedEvent == value)
				{
					return;
				}
				_openFailedEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get
			{
				if (_closeEvent == null)
				{
					_closeEvent = (CName) CR2WTypeManager.Create("CName", "closeEvent", cr2w, this);
				}
				return _closeEvent;
			}
			set
			{
				if (_closeEvent == value)
				{
					return;
				}
				_closeEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lockEvent")] 
		public CName LockEvent
		{
			get
			{
				if (_lockEvent == null)
				{
					_lockEvent = (CName) CR2WTypeManager.Create("CName", "lockEvent", cr2w, this);
				}
				return _lockEvent;
			}
			set
			{
				if (_lockEvent == value)
				{
					return;
				}
				_lockEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("unlockEvent")] 
		public CName UnlockEvent
		{
			get
			{
				if (_unlockEvent == null)
				{
					_unlockEvent = (CName) CR2WTypeManager.Create("CName", "unlockEvent", cr2w, this);
				}
				return _unlockEvent;
			}
			set
			{
				if (_unlockEvent == value)
				{
					return;
				}
				_unlockEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sealEvent")] 
		public CName SealEvent
		{
			get
			{
				if (_sealEvent == null)
				{
					_sealEvent = (CName) CR2WTypeManager.Create("CName", "sealEvent", cr2w, this);
				}
				return _sealEvent;
			}
			set
			{
				if (_sealEvent == value)
				{
					return;
				}
				_sealEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("soundBank")] 
		public CName SoundBank
		{
			get
			{
				if (_soundBank == null)
				{
					_soundBank = (CName) CR2WTypeManager.Create("CName", "soundBank", cr2w, this);
				}
				return _soundBank;
			}
			set
			{
				if (_soundBank == value)
				{
					return;
				}
				_soundBank = value;
				PropertySet(this);
			}
		}

		public audioDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
