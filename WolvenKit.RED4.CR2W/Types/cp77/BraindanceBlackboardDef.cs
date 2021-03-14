using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _activeBraindanceVisionMode;
		private gamebbScriptID_Int32 _lastBraindanceVisionMode;
		private gamebbScriptID_Float _progress;
		private gamebbScriptID_Float _sectionTime;
		private gamebbScriptID_Variant _clue;
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Bool _enableExit;
		private gamebbScriptID_Bool _isFPP;
		private gamebbScriptID_Variant _playbackSpeed;
		private gamebbScriptID_Variant _playbackDirection;

		[Ordinal(0)] 
		[RED("activeBraindanceVisionMode")] 
		public gamebbScriptID_Int32 ActiveBraindanceVisionMode
		{
			get
			{
				if (_activeBraindanceVisionMode == null)
				{
					_activeBraindanceVisionMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "activeBraindanceVisionMode", cr2w, this);
				}
				return _activeBraindanceVisionMode;
			}
			set
			{
				if (_activeBraindanceVisionMode == value)
				{
					return;
				}
				_activeBraindanceVisionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastBraindanceVisionMode")] 
		public gamebbScriptID_Int32 LastBraindanceVisionMode
		{
			get
			{
				if (_lastBraindanceVisionMode == null)
				{
					_lastBraindanceVisionMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "lastBraindanceVisionMode", cr2w, this);
				}
				return _lastBraindanceVisionMode;
			}
			set
			{
				if (_lastBraindanceVisionMode == value)
				{
					return;
				}
				_lastBraindanceVisionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get
			{
				if (_progress == null)
				{
					_progress = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "Progress", cr2w, this);
				}
				return _progress;
			}
			set
			{
				if (_progress == value)
				{
					return;
				}
				_progress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("SectionTime")] 
		public gamebbScriptID_Float SectionTime
		{
			get
			{
				if (_sectionTime == null)
				{
					_sectionTime = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "SectionTime", cr2w, this);
				}
				return _sectionTime;
			}
			set
			{
				if (_sectionTime == value)
				{
					return;
				}
				_sectionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("Clue")] 
		public gamebbScriptID_Variant Clue
		{
			get
			{
				if (_clue == null)
				{
					_clue = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Clue", cr2w, this);
				}
				return _clue;
			}
			set
			{
				if (_clue == value)
				{
					return;
				}
				_clue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("EnableExit")] 
		public gamebbScriptID_Bool EnableExit
		{
			get
			{
				if (_enableExit == null)
				{
					_enableExit = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "EnableExit", cr2w, this);
				}
				return _enableExit;
			}
			set
			{
				if (_enableExit == value)
				{
					return;
				}
				_enableExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsFPP")] 
		public gamebbScriptID_Bool IsFPP
		{
			get
			{
				if (_isFPP == null)
				{
					_isFPP = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsFPP", cr2w, this);
				}
				return _isFPP;
			}
			set
			{
				if (_isFPP == value)
				{
					return;
				}
				_isFPP = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("PlaybackSpeed")] 
		public gamebbScriptID_Variant PlaybackSpeed
		{
			get
			{
				if (_playbackSpeed == null)
				{
					_playbackSpeed = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "PlaybackSpeed", cr2w, this);
				}
				return _playbackSpeed;
			}
			set
			{
				if (_playbackSpeed == value)
				{
					return;
				}
				_playbackSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("PlaybackDirection")] 
		public gamebbScriptID_Variant PlaybackDirection
		{
			get
			{
				if (_playbackDirection == null)
				{
					_playbackDirection = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "PlaybackDirection", cr2w, this);
				}
				return _playbackDirection;
			}
			set
			{
				if (_playbackDirection == value)
				{
					return;
				}
				_playbackDirection = value;
				PropertySet(this);
			}
		}

		public BraindanceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
