using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubtitleLineLogicController : BaseSubtitleLineLogicController
	{
		private inkTextWidgetReference _speakerNameWidget;
		private inkTextWidgetReference _subtitleWidget;
		private inkTextWidgetReference _radioSpeaker;
		private inkTextWidgetReference _radioSubtitle;
		private inkWidgetReference _background;
		private inkWidgetReference _backgroundSpeaker;
		private inkWidgetReference _kiroshiAnimationContainer;
		private inkWidgetReference _motherTongueContainter;
		private inkTextWidgetReference _targetTextWidgetRef;
		private scnDialogLineData _lineData;

		[Ordinal(5)] 
		[RED("speakerNameWidget")] 
		public inkTextWidgetReference SpeakerNameWidget
		{
			get
			{
				if (_speakerNameWidget == null)
				{
					_speakerNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "speakerNameWidget", cr2w, this);
				}
				return _speakerNameWidget;
			}
			set
			{
				if (_speakerNameWidget == value)
				{
					return;
				}
				_speakerNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("subtitleWidget")] 
		public inkTextWidgetReference SubtitleWidget
		{
			get
			{
				if (_subtitleWidget == null)
				{
					_subtitleWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subtitleWidget", cr2w, this);
				}
				return _subtitleWidget;
			}
			set
			{
				if (_subtitleWidget == value)
				{
					return;
				}
				_subtitleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("radioSpeaker")] 
		public inkTextWidgetReference RadioSpeaker
		{
			get
			{
				if (_radioSpeaker == null)
				{
					_radioSpeaker = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "radioSpeaker", cr2w, this);
				}
				return _radioSpeaker;
			}
			set
			{
				if (_radioSpeaker == value)
				{
					return;
				}
				_radioSpeaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("radioSubtitle")] 
		public inkTextWidgetReference RadioSubtitle
		{
			get
			{
				if (_radioSubtitle == null)
				{
					_radioSubtitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "radioSubtitle", cr2w, this);
				}
				return _radioSubtitle;
			}
			set
			{
				if (_radioSubtitle == value)
				{
					return;
				}
				_radioSubtitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("backgroundSpeaker")] 
		public inkWidgetReference BackgroundSpeaker
		{
			get
			{
				if (_backgroundSpeaker == null)
				{
					_backgroundSpeaker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backgroundSpeaker", cr2w, this);
				}
				return _backgroundSpeaker;
			}
			set
			{
				if (_backgroundSpeaker == value)
				{
					return;
				}
				_backgroundSpeaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("kiroshiAnimationContainer")] 
		public inkWidgetReference KiroshiAnimationContainer
		{
			get
			{
				if (_kiroshiAnimationContainer == null)
				{
					_kiroshiAnimationContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "kiroshiAnimationContainer", cr2w, this);
				}
				return _kiroshiAnimationContainer;
			}
			set
			{
				if (_kiroshiAnimationContainer == value)
				{
					return;
				}
				_kiroshiAnimationContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("motherTongueContainter")] 
		public inkWidgetReference MotherTongueContainter
		{
			get
			{
				if (_motherTongueContainter == null)
				{
					_motherTongueContainter = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "motherTongueContainter", cr2w, this);
				}
				return _motherTongueContainter;
			}
			set
			{
				if (_motherTongueContainter == value)
				{
					return;
				}
				_motherTongueContainter = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetTextWidgetRef")] 
		public inkTextWidgetReference TargetTextWidgetRef
		{
			get
			{
				if (_targetTextWidgetRef == null)
				{
					_targetTextWidgetRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "targetTextWidgetRef", cr2w, this);
				}
				return _targetTextWidgetRef;
			}
			set
			{
				if (_targetTextWidgetRef == value)
				{
					return;
				}
				_targetTextWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lineData")] 
		public scnDialogLineData LineData
		{
			get
			{
				if (_lineData == null)
				{
					_lineData = (scnDialogLineData) CR2WTypeManager.Create("scnDialogLineData", "lineData", cr2w, this);
				}
				return _lineData;
			}
			set
			{
				if (_lineData == value)
				{
					return;
				}
				_lineData = value;
				PropertySet(this);
			}
		}

		public SubtitleLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
