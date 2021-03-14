using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDialogLineEventData : CVariable
	{
		private CRUID _stringId;
		private CEnum<locVoiceoverContext> _context;
		private CEnum<locVoiceoverExpression> _expression;
		private CBool _isPlayer;
		private CBool _isRewind;
		private CBool _isHolocall;
		private CName _customVoEvent;
		private CFloat _seekTime;
		private CFloat _playbackSpeedParameter;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get
			{
				if (_stringId == null)
				{
					_stringId = (CRUID) CR2WTypeManager.Create("CRUID", "stringId", cr2w, this);
				}
				return _stringId;
			}
			set
			{
				if (_stringId == value)
				{
					return;
				}
				_stringId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CEnum<locVoiceoverContext> Context
		{
			get
			{
				if (_context == null)
				{
					_context = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("expression")] 
		public CEnum<locVoiceoverExpression> Expression
		{
			get
			{
				if (_expression == null)
				{
					_expression = (CEnum<locVoiceoverExpression>) CR2WTypeManager.Create("locVoiceoverExpression", "expression", cr2w, this);
				}
				return _expression;
			}
			set
			{
				if (_expression == value)
				{
					return;
				}
				_expression = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isRewind")] 
		public CBool IsRewind
		{
			get
			{
				if (_isRewind == null)
				{
					_isRewind = (CBool) CR2WTypeManager.Create("Bool", "isRewind", cr2w, this);
				}
				return _isRewind;
			}
			set
			{
				if (_isRewind == value)
				{
					return;
				}
				_isRewind = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isHolocall")] 
		public CBool IsHolocall
		{
			get
			{
				if (_isHolocall == null)
				{
					_isHolocall = (CBool) CR2WTypeManager.Create("Bool", "isHolocall", cr2w, this);
				}
				return _isHolocall;
			}
			set
			{
				if (_isHolocall == value)
				{
					return;
				}
				_isHolocall = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("customVoEvent")] 
		public CName CustomVoEvent
		{
			get
			{
				if (_customVoEvent == null)
				{
					_customVoEvent = (CName) CR2WTypeManager.Create("CName", "customVoEvent", cr2w, this);
				}
				return _customVoEvent;
			}
			set
			{
				if (_customVoEvent == value)
				{
					return;
				}
				_customVoEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("seekTime")] 
		public CFloat SeekTime
		{
			get
			{
				if (_seekTime == null)
				{
					_seekTime = (CFloat) CR2WTypeManager.Create("Float", "seekTime", cr2w, this);
				}
				return _seekTime;
			}
			set
			{
				if (_seekTime == value)
				{
					return;
				}
				_seekTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playbackSpeedParameter")] 
		public CFloat PlaybackSpeedParameter
		{
			get
			{
				if (_playbackSpeedParameter == null)
				{
					_playbackSpeedParameter = (CFloat) CR2WTypeManager.Create("Float", "playbackSpeedParameter", cr2w, this);
				}
				return _playbackSpeedParameter;
			}
			set
			{
				if (_playbackSpeedParameter == value)
				{
					return;
				}
				_playbackSpeedParameter = value;
				PropertySet(this);
			}
		}

		public audioDialogLineEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
