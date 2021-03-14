using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineVoParams : CVariable
	{
		private CEnum<locVoiceoverContext> _voContext;
		private CEnum<locVoiceoverExpression> _voExpression;
		private CName _customVoEvent;
		private CBool _disableHeadMovement;
		private CBool _isHolocallSpeaker;
		private CBool _ignoreSpeakerIncapacitation;
		private CBool _alwaysUseBrainGender;

		[Ordinal(0)] 
		[RED("voContext")] 
		public CEnum<locVoiceoverContext> VoContext
		{
			get
			{
				if (_voContext == null)
				{
					_voContext = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "voContext", cr2w, this);
				}
				return _voContext;
			}
			set
			{
				if (_voContext == value)
				{
					return;
				}
				_voContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voExpression")] 
		public CEnum<locVoiceoverExpression> VoExpression
		{
			get
			{
				if (_voExpression == null)
				{
					_voExpression = (CEnum<locVoiceoverExpression>) CR2WTypeManager.Create("locVoiceoverExpression", "voExpression", cr2w, this);
				}
				return _voExpression;
			}
			set
			{
				if (_voExpression == value)
				{
					return;
				}
				_voExpression = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("disableHeadMovement")] 
		public CBool DisableHeadMovement
		{
			get
			{
				if (_disableHeadMovement == null)
				{
					_disableHeadMovement = (CBool) CR2WTypeManager.Create("Bool", "disableHeadMovement", cr2w, this);
				}
				return _disableHeadMovement;
			}
			set
			{
				if (_disableHeadMovement == value)
				{
					return;
				}
				_disableHeadMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isHolocallSpeaker")] 
		public CBool IsHolocallSpeaker
		{
			get
			{
				if (_isHolocallSpeaker == null)
				{
					_isHolocallSpeaker = (CBool) CR2WTypeManager.Create("Bool", "isHolocallSpeaker", cr2w, this);
				}
				return _isHolocallSpeaker;
			}
			set
			{
				if (_isHolocallSpeaker == value)
				{
					return;
				}
				_isHolocallSpeaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ignoreSpeakerIncapacitation")] 
		public CBool IgnoreSpeakerIncapacitation
		{
			get
			{
				if (_ignoreSpeakerIncapacitation == null)
				{
					_ignoreSpeakerIncapacitation = (CBool) CR2WTypeManager.Create("Bool", "ignoreSpeakerIncapacitation", cr2w, this);
				}
				return _ignoreSpeakerIncapacitation;
			}
			set
			{
				if (_ignoreSpeakerIncapacitation == value)
				{
					return;
				}
				_ignoreSpeakerIncapacitation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("alwaysUseBrainGender")] 
		public CBool AlwaysUseBrainGender
		{
			get
			{
				if (_alwaysUseBrainGender == null)
				{
					_alwaysUseBrainGender = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseBrainGender", cr2w, this);
				}
				return _alwaysUseBrainGender;
			}
			set
			{
				if (_alwaysUseBrainGender == value)
				{
					return;
				}
				_alwaysUseBrainGender = value;
				PropertySet(this);
			}
		}

		public scnDialogLineVoParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
