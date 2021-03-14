using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessPoint : InteractiveMasterDevice
	{
		private CHandle<gameLightComponent> _diode0;
		private CHandle<gameLightComponent> _diode1;
		private CHandle<gameLightComponent> _diode2;
		private CHandle<gameLightComponent> _diode3;
		private CFloat _elapsedTime;
		private CBool _turnOnLight;
		private CString _networkName;
		private CBool _isPlayerInBreachView;
		private CBool _isRevealed;
		private CHandle<BreachViewTimeListener> _breachViewTimeListener;
		private CUInt32 _upload_program_listener_id;

		[Ordinal(93)] 
		[RED("diode0")] 
		public CHandle<gameLightComponent> Diode0
		{
			get
			{
				if (_diode0 == null)
				{
					_diode0 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "diode0", cr2w, this);
				}
				return _diode0;
			}
			set
			{
				if (_diode0 == value)
				{
					return;
				}
				_diode0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("diode1")] 
		public CHandle<gameLightComponent> Diode1
		{
			get
			{
				if (_diode1 == null)
				{
					_diode1 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "diode1", cr2w, this);
				}
				return _diode1;
			}
			set
			{
				if (_diode1 == value)
				{
					return;
				}
				_diode1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("diode2")] 
		public CHandle<gameLightComponent> Diode2
		{
			get
			{
				if (_diode2 == null)
				{
					_diode2 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "diode2", cr2w, this);
				}
				return _diode2;
			}
			set
			{
				if (_diode2 == value)
				{
					return;
				}
				_diode2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("diode3")] 
		public CHandle<gameLightComponent> Diode3
		{
			get
			{
				if (_diode3 == null)
				{
					_diode3 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "diode3", cr2w, this);
				}
				return _diode3;
			}
			set
			{
				if (_diode3 == value)
				{
					return;
				}
				_diode3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("elapsedTime")] 
		public CFloat ElapsedTime
		{
			get
			{
				if (_elapsedTime == null)
				{
					_elapsedTime = (CFloat) CR2WTypeManager.Create("Float", "elapsedTime", cr2w, this);
				}
				return _elapsedTime;
			}
			set
			{
				if (_elapsedTime == value)
				{
					return;
				}
				_elapsedTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("turnOnLight")] 
		public CBool TurnOnLight
		{
			get
			{
				if (_turnOnLight == null)
				{
					_turnOnLight = (CBool) CR2WTypeManager.Create("Bool", "turnOnLight", cr2w, this);
				}
				return _turnOnLight;
			}
			set
			{
				if (_turnOnLight == value)
				{
					return;
				}
				_turnOnLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get
			{
				if (_networkName == null)
				{
					_networkName = (CString) CR2WTypeManager.Create("String", "networkName", cr2w, this);
				}
				return _networkName;
			}
			set
			{
				if (_networkName == value)
				{
					return;
				}
				_networkName = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("isPlayerInBreachView")] 
		public CBool IsPlayerInBreachView
		{
			get
			{
				if (_isPlayerInBreachView == null)
				{
					_isPlayerInBreachView = (CBool) CR2WTypeManager.Create("Bool", "isPlayerInBreachView", cr2w, this);
				}
				return _isPlayerInBreachView;
			}
			set
			{
				if (_isPlayerInBreachView == value)
				{
					return;
				}
				_isPlayerInBreachView = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get
			{
				if (_isRevealed == null)
				{
					_isRevealed = (CBool) CR2WTypeManager.Create("Bool", "isRevealed", cr2w, this);
				}
				return _isRevealed;
			}
			set
			{
				if (_isRevealed == value)
				{
					return;
				}
				_isRevealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("breachViewTimeListener")] 
		public CHandle<BreachViewTimeListener> BreachViewTimeListener
		{
			get
			{
				if (_breachViewTimeListener == null)
				{
					_breachViewTimeListener = (CHandle<BreachViewTimeListener>) CR2WTypeManager.Create("handle:BreachViewTimeListener", "breachViewTimeListener", cr2w, this);
				}
				return _breachViewTimeListener;
			}
			set
			{
				if (_breachViewTimeListener == value)
				{
					return;
				}
				_breachViewTimeListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("upload_program_listener_id")] 
		public CUInt32 Upload_program_listener_id
		{
			get
			{
				if (_upload_program_listener_id == null)
				{
					_upload_program_listener_id = (CUInt32) CR2WTypeManager.Create("Uint32", "upload_program_listener_id", cr2w, this);
				}
				return _upload_program_listener_id;
			}
			set
			{
				if (_upload_program_listener_id == value)
				{
					return;
				}
				_upload_program_listener_id = value;
				PropertySet(this);
			}
		}

		public AccessPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
