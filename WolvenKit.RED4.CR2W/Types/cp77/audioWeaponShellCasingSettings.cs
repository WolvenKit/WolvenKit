using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponShellCasingSettings : audioAudioMetadata
	{
		private CEnum<audioWeaponShellCasingMode> _mode;
		private CEnum<audioWeaponShellCasingDirection> _direction;
		private CName _firstCollisionEventName;
		private CName _secondCollisionEventName;
		private CFloat _initialDelay;

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<audioWeaponShellCasingMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<audioWeaponShellCasingMode>) CR2WTypeManager.Create("audioWeaponShellCasingMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<audioWeaponShellCasingDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<audioWeaponShellCasingDirection>) CR2WTypeManager.Create("audioWeaponShellCasingDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("firstCollisionEventName")] 
		public CName FirstCollisionEventName
		{
			get
			{
				if (_firstCollisionEventName == null)
				{
					_firstCollisionEventName = (CName) CR2WTypeManager.Create("CName", "firstCollisionEventName", cr2w, this);
				}
				return _firstCollisionEventName;
			}
			set
			{
				if (_firstCollisionEventName == value)
				{
					return;
				}
				_firstCollisionEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("secondCollisionEventName")] 
		public CName SecondCollisionEventName
		{
			get
			{
				if (_secondCollisionEventName == null)
				{
					_secondCollisionEventName = (CName) CR2WTypeManager.Create("CName", "secondCollisionEventName", cr2w, this);
				}
				return _secondCollisionEventName;
			}
			set
			{
				if (_secondCollisionEventName == value)
				{
					return;
				}
				_secondCollisionEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("initialDelay")] 
		public CFloat InitialDelay
		{
			get
			{
				if (_initialDelay == null)
				{
					_initialDelay = (CFloat) CR2WTypeManager.Create("Float", "initialDelay", cr2w, this);
				}
				return _initialDelay;
			}
			set
			{
				if (_initialDelay == value)
				{
					return;
				}
				_initialDelay = value;
				PropertySet(this);
			}
		}

		public audioWeaponShellCasingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
