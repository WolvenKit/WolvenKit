using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimVideoInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;
		private CBool _synchronizeToAudio;
		private CBool _allowSkipBackward;
		private CName _audioEvent;
		private CBool _retriggerAudioOnLoop;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (CFloat) CR2WTypeManager.Create("Float", "startValue", cr2w, this);
				}
				return _startValue;
			}
			set
			{
				if (_startValue == value)
				{
					return;
				}
				_startValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (CFloat) CR2WTypeManager.Create("Float", "endValue", cr2w, this);
				}
				return _endValue;
			}
			set
			{
				if (_endValue == value)
				{
					return;
				}
				_endValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("synchronizeToAudio")] 
		public CBool SynchronizeToAudio
		{
			get
			{
				if (_synchronizeToAudio == null)
				{
					_synchronizeToAudio = (CBool) CR2WTypeManager.Create("Bool", "synchronizeToAudio", cr2w, this);
				}
				return _synchronizeToAudio;
			}
			set
			{
				if (_synchronizeToAudio == value)
				{
					return;
				}
				_synchronizeToAudio = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("allowSkipBackward")] 
		public CBool AllowSkipBackward
		{
			get
			{
				if (_allowSkipBackward == null)
				{
					_allowSkipBackward = (CBool) CR2WTypeManager.Create("Bool", "allowSkipBackward", cr2w, this);
				}
				return _allowSkipBackward;
			}
			set
			{
				if (_allowSkipBackward == value)
				{
					return;
				}
				_allowSkipBackward = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get
			{
				if (_audioEvent == null)
				{
					_audioEvent = (CName) CR2WTypeManager.Create("CName", "audioEvent", cr2w, this);
				}
				return _audioEvent;
			}
			set
			{
				if (_audioEvent == value)
				{
					return;
				}
				_audioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get
			{
				if (_retriggerAudioOnLoop == null)
				{
					_retriggerAudioOnLoop = (CBool) CR2WTypeManager.Create("Bool", "retriggerAudioOnLoop", cr2w, this);
				}
				return _retriggerAudioOnLoop;
			}
			set
			{
				if (_retriggerAudioOnLoop == value)
				{
					return;
				}
				_retriggerAudioOnLoop = value;
				PropertySet(this);
			}
		}

		public inkanimVideoInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
