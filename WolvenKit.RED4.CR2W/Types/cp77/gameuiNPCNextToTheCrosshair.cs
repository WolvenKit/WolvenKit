using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNPCNextToTheCrosshair : CVariable
	{
		private wCHandle<gameObject> _npc;
		private CString _name;
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CInt32 _currentCyberwarePct;
		private CInt32 _level;
		private CInt32 _quickHackUpload;
		private CEnum<EAIAttitude> _attitude;
		private CEnum<gameScanningState> _scanningState;
		private CBool _isTagged;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CBool _canSeePlayer;
		private CBool _playerDetectionAboveZero;
		private CBool _playerDetectionAtMax;

		[Ordinal(0)] 
		[RED("npc")] 
		public wCHandle<gameObject> Npc
		{
			get
			{
				if (_npc == null)
				{
					_npc = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "npc", cr2w, this);
				}
				return _npc;
			}
			set
			{
				if (_npc == value)
				{
					return;
				}
				_npc = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentCyberwarePct")] 
		public CInt32 CurrentCyberwarePct
		{
			get
			{
				if (_currentCyberwarePct == null)
				{
					_currentCyberwarePct = (CInt32) CR2WTypeManager.Create("Int32", "currentCyberwarePct", cr2w, this);
				}
				return _currentCyberwarePct;
			}
			set
			{
				if (_currentCyberwarePct == value)
				{
					return;
				}
				_currentCyberwarePct = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("quickHackUpload")] 
		public CInt32 QuickHackUpload
		{
			get
			{
				if (_quickHackUpload == null)
				{
					_quickHackUpload = (CInt32) CR2WTypeManager.Create("Int32", "quickHackUpload", cr2w, this);
				}
				return _quickHackUpload;
			}
			set
			{
				if (_quickHackUpload == value)
				{
					return;
				}
				_quickHackUpload = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (CEnum<EAIAttitude>) CR2WTypeManager.Create("EAIAttitude", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get
			{
				if (_scanningState == null)
				{
					_scanningState = (CEnum<gameScanningState>) CR2WTypeManager.Create("gameScanningState", "scanningState", cr2w, this);
				}
				return _scanningState;
			}
			set
			{
				if (_scanningState == value)
				{
					return;
				}
				_scanningState = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get
			{
				if (_isTagged == null)
				{
					_isTagged = (CBool) CR2WTypeManager.Create("Bool", "isTagged", cr2w, this);
				}
				return _isTagged;
			}
			set
			{
				if (_isTagged == value)
				{
					return;
				}
				_isTagged = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get
			{
				if (_canSeePlayer == null)
				{
					_canSeePlayer = (CBool) CR2WTypeManager.Create("Bool", "canSeePlayer", cr2w, this);
				}
				return _canSeePlayer;
			}
			set
			{
				if (_canSeePlayer == value)
				{
					return;
				}
				_canSeePlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerDetectionAboveZero")] 
		public CBool PlayerDetectionAboveZero
		{
			get
			{
				if (_playerDetectionAboveZero == null)
				{
					_playerDetectionAboveZero = (CBool) CR2WTypeManager.Create("Bool", "playerDetectionAboveZero", cr2w, this);
				}
				return _playerDetectionAboveZero;
			}
			set
			{
				if (_playerDetectionAboveZero == value)
				{
					return;
				}
				_playerDetectionAboveZero = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("playerDetectionAtMax")] 
		public CBool PlayerDetectionAtMax
		{
			get
			{
				if (_playerDetectionAtMax == null)
				{
					_playerDetectionAtMax = (CBool) CR2WTypeManager.Create("Bool", "playerDetectionAtMax", cr2w, this);
				}
				return _playerDetectionAtMax;
			}
			set
			{
				if (_playerDetectionAtMax == value)
				{
					return;
				}
				_playerDetectionAtMax = value;
				PropertySet(this);
			}
		}

		public gameuiNPCNextToTheCrosshair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
