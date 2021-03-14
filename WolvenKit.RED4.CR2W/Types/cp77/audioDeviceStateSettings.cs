using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDeviceStateSettings : CVariable
	{
		private CName _powerRestoredSound;
		private CName _powerCutSound;
		private CName _turnOnSound;
		private CName _turnOffSound;
		private CName _breakingSound;

		[Ordinal(0)] 
		[RED("powerRestoredSound")] 
		public CName PowerRestoredSound
		{
			get
			{
				if (_powerRestoredSound == null)
				{
					_powerRestoredSound = (CName) CR2WTypeManager.Create("CName", "powerRestoredSound", cr2w, this);
				}
				return _powerRestoredSound;
			}
			set
			{
				if (_powerRestoredSound == value)
				{
					return;
				}
				_powerRestoredSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("powerCutSound")] 
		public CName PowerCutSound
		{
			get
			{
				if (_powerCutSound == null)
				{
					_powerCutSound = (CName) CR2WTypeManager.Create("CName", "powerCutSound", cr2w, this);
				}
				return _powerCutSound;
			}
			set
			{
				if (_powerCutSound == value)
				{
					return;
				}
				_powerCutSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("turnOnSound")] 
		public CName TurnOnSound
		{
			get
			{
				if (_turnOnSound == null)
				{
					_turnOnSound = (CName) CR2WTypeManager.Create("CName", "turnOnSound", cr2w, this);
				}
				return _turnOnSound;
			}
			set
			{
				if (_turnOnSound == value)
				{
					return;
				}
				_turnOnSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("turnOffSound")] 
		public CName TurnOffSound
		{
			get
			{
				if (_turnOffSound == null)
				{
					_turnOffSound = (CName) CR2WTypeManager.Create("CName", "turnOffSound", cr2w, this);
				}
				return _turnOffSound;
			}
			set
			{
				if (_turnOffSound == value)
				{
					return;
				}
				_turnOffSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("breakingSound")] 
		public CName BreakingSound
		{
			get
			{
				if (_breakingSound == null)
				{
					_breakingSound = (CName) CR2WTypeManager.Create("CName", "breakingSound", cr2w, this);
				}
				return _breakingSound;
			}
			set
			{
				if (_breakingSound == value)
				{
					return;
				}
				_breakingSound = value;
				PropertySet(this);
			}
		}

		public audioDeviceStateSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
