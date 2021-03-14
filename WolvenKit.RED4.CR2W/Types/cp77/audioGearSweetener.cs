using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGearSweetener : audioAudioMetadata
	{
		private CUInt32 _gear;
		private CFloat _rpmThreshold;
		private CFloat _cooldown;
		private CName _soundEvent;
		private CFloat _burnoutFactor;

		[Ordinal(1)] 
		[RED("gear")] 
		public CUInt32 Gear
		{
			get
			{
				if (_gear == null)
				{
					_gear = (CUInt32) CR2WTypeManager.Create("Uint32", "gear", cr2w, this);
				}
				return _gear;
			}
			set
			{
				if (_gear == value)
				{
					return;
				}
				_gear = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rpmThreshold")] 
		public CFloat RpmThreshold
		{
			get
			{
				if (_rpmThreshold == null)
				{
					_rpmThreshold = (CFloat) CR2WTypeManager.Create("Float", "rpmThreshold", cr2w, this);
				}
				return _rpmThreshold;
			}
			set
			{
				if (_rpmThreshold == value)
				{
					return;
				}
				_rpmThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get
			{
				if (_soundEvent == null)
				{
					_soundEvent = (CName) CR2WTypeManager.Create("CName", "soundEvent", cr2w, this);
				}
				return _soundEvent;
			}
			set
			{
				if (_soundEvent == value)
				{
					return;
				}
				_soundEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("burnoutFactor")] 
		public CFloat BurnoutFactor
		{
			get
			{
				if (_burnoutFactor == null)
				{
					_burnoutFactor = (CFloat) CR2WTypeManager.Create("Float", "burnoutFactor", cr2w, this);
				}
				return _burnoutFactor;
			}
			set
			{
				if (_burnoutFactor == value)
				{
					return;
				}
				_burnoutFactor = value;
				PropertySet(this);
			}
		}

		public audioGearSweetener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
