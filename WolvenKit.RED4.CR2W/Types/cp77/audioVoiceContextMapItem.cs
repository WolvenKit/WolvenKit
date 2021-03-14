using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMapItem : audioAudioMetadata
	{
		private CName _voTrigger;
		private CEnum<audioVoBarkType> _bark;
		private CEnum<audioVoGruntType> _grunt;
		private audioVoiceContextAnswer _answer;
		private CEnum<locVoiceoverContext> _overridingVoContext;
		private CEnum<audioVoGruntInterruptMode> _gruntInterruptMode;

		[Ordinal(1)] 
		[RED("voTrigger")] 
		public CName VoTrigger
		{
			get
			{
				if (_voTrigger == null)
				{
					_voTrigger = (CName) CR2WTypeManager.Create("CName", "voTrigger", cr2w, this);
				}
				return _voTrigger;
			}
			set
			{
				if (_voTrigger == value)
				{
					return;
				}
				_voTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bark")] 
		public CEnum<audioVoBarkType> Bark
		{
			get
			{
				if (_bark == null)
				{
					_bark = (CEnum<audioVoBarkType>) CR2WTypeManager.Create("audioVoBarkType", "bark", cr2w, this);
				}
				return _bark;
			}
			set
			{
				if (_bark == value)
				{
					return;
				}
				_bark = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("grunt")] 
		public CEnum<audioVoGruntType> Grunt
		{
			get
			{
				if (_grunt == null)
				{
					_grunt = (CEnum<audioVoGruntType>) CR2WTypeManager.Create("audioVoGruntType", "grunt", cr2w, this);
				}
				return _grunt;
			}
			set
			{
				if (_grunt == value)
				{
					return;
				}
				_grunt = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("answer")] 
		public audioVoiceContextAnswer Answer
		{
			get
			{
				if (_answer == null)
				{
					_answer = (audioVoiceContextAnswer) CR2WTypeManager.Create("audioVoiceContextAnswer", "answer", cr2w, this);
				}
				return _answer;
			}
			set
			{
				if (_answer == value)
				{
					return;
				}
				_answer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get
			{
				if (_overridingVoContext == null)
				{
					_overridingVoContext = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "overridingVoContext", cr2w, this);
				}
				return _overridingVoContext;
			}
			set
			{
				if (_overridingVoContext == value)
				{
					return;
				}
				_overridingVoContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gruntInterruptMode")] 
		public CEnum<audioVoGruntInterruptMode> GruntInterruptMode
		{
			get
			{
				if (_gruntInterruptMode == null)
				{
					_gruntInterruptMode = (CEnum<audioVoGruntInterruptMode>) CR2WTypeManager.Create("audioVoGruntInterruptMode", "gruntInterruptMode", cr2w, this);
				}
				return _gruntInterruptMode;
			}
			set
			{
				if (_gruntInterruptMode == value)
				{
					return;
				}
				_gruntInterruptMode = value;
				PropertySet(this);
			}
		}

		public audioVoiceContextMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
