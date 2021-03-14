using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirVoice : audioAudioMetadata
	{
		private CName _fireSound;
		private CName _burstFireSound;
		private CName _chargedSound;
		private CName _autoFireSound;
		private CName _autoFireStop;
		private CName _shutdown;
		private CName _init;

		[Ordinal(1)] 
		[RED("fireSound")] 
		public CName FireSound
		{
			get
			{
				if (_fireSound == null)
				{
					_fireSound = (CName) CR2WTypeManager.Create("CName", "fireSound", cr2w, this);
				}
				return _fireSound;
			}
			set
			{
				if (_fireSound == value)
				{
					return;
				}
				_fireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get
			{
				if (_burstFireSound == null)
				{
					_burstFireSound = (CName) CR2WTypeManager.Create("CName", "burstFireSound", cr2w, this);
				}
				return _burstFireSound;
			}
			set
			{
				if (_burstFireSound == value)
				{
					return;
				}
				_burstFireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("chargedSound")] 
		public CName ChargedSound
		{
			get
			{
				if (_chargedSound == null)
				{
					_chargedSound = (CName) CR2WTypeManager.Create("CName", "chargedSound", cr2w, this);
				}
				return _chargedSound;
			}
			set
			{
				if (_chargedSound == value)
				{
					return;
				}
				_chargedSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get
			{
				if (_autoFireSound == null)
				{
					_autoFireSound = (CName) CR2WTypeManager.Create("CName", "autoFireSound", cr2w, this);
				}
				return _autoFireSound;
			}
			set
			{
				if (_autoFireSound == value)
				{
					return;
				}
				_autoFireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get
			{
				if (_autoFireStop == null)
				{
					_autoFireStop = (CName) CR2WTypeManager.Create("CName", "autoFireStop", cr2w, this);
				}
				return _autoFireStop;
			}
			set
			{
				if (_autoFireStop == value)
				{
					return;
				}
				_autoFireStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("shutdown")] 
		public CName Shutdown
		{
			get
			{
				if (_shutdown == null)
				{
					_shutdown = (CName) CR2WTypeManager.Create("CName", "shutdown", cr2w, this);
				}
				return _shutdown;
			}
			set
			{
				if (_shutdown == value)
				{
					return;
				}
				_shutdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("init")] 
		public CName Init
		{
			get
			{
				if (_init == null)
				{
					_init = (CName) CR2WTypeManager.Create("CName", "init", cr2w, this);
				}
				return _init;
			}
			set
			{
				if (_init == value)
				{
					return;
				}
				_init = value;
				PropertySet(this);
			}
		}

		public audioNpcGunChoirVoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
