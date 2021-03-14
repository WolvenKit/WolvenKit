using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUITextSystemController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _locKeyTextWidget;
		private inkTextWidgetReference _localizedTextWidget;
		private CHandle<textTextParameterSet> _textParams;
		private inkTextWidgetReference _numberTextWidget;
		private inkWidgetReference _numberIncreaseButton;
		private inkWidgetReference _numberDecreaseButton;
		private CInt32 _numberToInject;
		private inkTextInputWidgetReference _stringTextInputWidget;
		private CString _stringToInject;
		private inkWidgetReference _timeRefreshButton;
		private CArray<inkWidgetReference> _measurementWidgets;
		private inkWidgetReference _metricSystemButton;
		private inkWidgetReference _imperialSystemButton;
		private inkWidgetReference _animateTextOffsetButton;
		private inkTextWidgetReference _textOffsetWidget;
		private inkWidgetReference _animateTextReplaceButton;
		private inkTextWidgetReference _textReplaceWidget;
		private inkWidgetReference _animateValueButton;
		private inkTextWidgetReference _animateValueWidget;

		[Ordinal(2)] 
		[RED("locKeyTextWidget")] 
		public inkTextWidgetReference LocKeyTextWidget
		{
			get
			{
				if (_locKeyTextWidget == null)
				{
					_locKeyTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "locKeyTextWidget", cr2w, this);
				}
				return _locKeyTextWidget;
			}
			set
			{
				if (_locKeyTextWidget == value)
				{
					return;
				}
				_locKeyTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localizedTextWidget")] 
		public inkTextWidgetReference LocalizedTextWidget
		{
			get
			{
				if (_localizedTextWidget == null)
				{
					_localizedTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "localizedTextWidget", cr2w, this);
				}
				return _localizedTextWidget;
			}
			set
			{
				if (_localizedTextWidget == value)
				{
					return;
				}
				_localizedTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get
			{
				if (_textParams == null)
				{
					_textParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "textParams", cr2w, this);
				}
				return _textParams;
			}
			set
			{
				if (_textParams == value)
				{
					return;
				}
				_textParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numberTextWidget")] 
		public inkTextWidgetReference NumberTextWidget
		{
			get
			{
				if (_numberTextWidget == null)
				{
					_numberTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "numberTextWidget", cr2w, this);
				}
				return _numberTextWidget;
			}
			set
			{
				if (_numberTextWidget == value)
				{
					return;
				}
				_numberTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numberIncreaseButton")] 
		public inkWidgetReference NumberIncreaseButton
		{
			get
			{
				if (_numberIncreaseButton == null)
				{
					_numberIncreaseButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "numberIncreaseButton", cr2w, this);
				}
				return _numberIncreaseButton;
			}
			set
			{
				if (_numberIncreaseButton == value)
				{
					return;
				}
				_numberIncreaseButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("numberDecreaseButton")] 
		public inkWidgetReference NumberDecreaseButton
		{
			get
			{
				if (_numberDecreaseButton == null)
				{
					_numberDecreaseButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "numberDecreaseButton", cr2w, this);
				}
				return _numberDecreaseButton;
			}
			set
			{
				if (_numberDecreaseButton == value)
				{
					return;
				}
				_numberDecreaseButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("numberToInject")] 
		public CInt32 NumberToInject
		{
			get
			{
				if (_numberToInject == null)
				{
					_numberToInject = (CInt32) CR2WTypeManager.Create("Int32", "numberToInject", cr2w, this);
				}
				return _numberToInject;
			}
			set
			{
				if (_numberToInject == value)
				{
					return;
				}
				_numberToInject = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stringTextInputWidget")] 
		public inkTextInputWidgetReference StringTextInputWidget
		{
			get
			{
				if (_stringTextInputWidget == null)
				{
					_stringTextInputWidget = (inkTextInputWidgetReference) CR2WTypeManager.Create("inkTextInputWidgetReference", "stringTextInputWidget", cr2w, this);
				}
				return _stringTextInputWidget;
			}
			set
			{
				if (_stringTextInputWidget == value)
				{
					return;
				}
				_stringTextInputWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("stringToInject")] 
		public CString StringToInject
		{
			get
			{
				if (_stringToInject == null)
				{
					_stringToInject = (CString) CR2WTypeManager.Create("String", "stringToInject", cr2w, this);
				}
				return _stringToInject;
			}
			set
			{
				if (_stringToInject == value)
				{
					return;
				}
				_stringToInject = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("timeRefreshButton")] 
		public inkWidgetReference TimeRefreshButton
		{
			get
			{
				if (_timeRefreshButton == null)
				{
					_timeRefreshButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "timeRefreshButton", cr2w, this);
				}
				return _timeRefreshButton;
			}
			set
			{
				if (_timeRefreshButton == value)
				{
					return;
				}
				_timeRefreshButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("measurementWidgets")] 
		public CArray<inkWidgetReference> MeasurementWidgets
		{
			get
			{
				if (_measurementWidgets == null)
				{
					_measurementWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "measurementWidgets", cr2w, this);
				}
				return _measurementWidgets;
			}
			set
			{
				if (_measurementWidgets == value)
				{
					return;
				}
				_measurementWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("metricSystemButton")] 
		public inkWidgetReference MetricSystemButton
		{
			get
			{
				if (_metricSystemButton == null)
				{
					_metricSystemButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "metricSystemButton", cr2w, this);
				}
				return _metricSystemButton;
			}
			set
			{
				if (_metricSystemButton == value)
				{
					return;
				}
				_metricSystemButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("imperialSystemButton")] 
		public inkWidgetReference ImperialSystemButton
		{
			get
			{
				if (_imperialSystemButton == null)
				{
					_imperialSystemButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "imperialSystemButton", cr2w, this);
				}
				return _imperialSystemButton;
			}
			set
			{
				if (_imperialSystemButton == value)
				{
					return;
				}
				_imperialSystemButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animateTextOffsetButton")] 
		public inkWidgetReference AnimateTextOffsetButton
		{
			get
			{
				if (_animateTextOffsetButton == null)
				{
					_animateTextOffsetButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animateTextOffsetButton", cr2w, this);
				}
				return _animateTextOffsetButton;
			}
			set
			{
				if (_animateTextOffsetButton == value)
				{
					return;
				}
				_animateTextOffsetButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("textOffsetWidget")] 
		public inkTextWidgetReference TextOffsetWidget
		{
			get
			{
				if (_textOffsetWidget == null)
				{
					_textOffsetWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textOffsetWidget", cr2w, this);
				}
				return _textOffsetWidget;
			}
			set
			{
				if (_textOffsetWidget == value)
				{
					return;
				}
				_textOffsetWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animateTextReplaceButton")] 
		public inkWidgetReference AnimateTextReplaceButton
		{
			get
			{
				if (_animateTextReplaceButton == null)
				{
					_animateTextReplaceButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animateTextReplaceButton", cr2w, this);
				}
				return _animateTextReplaceButton;
			}
			set
			{
				if (_animateTextReplaceButton == value)
				{
					return;
				}
				_animateTextReplaceButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("textReplaceWidget")] 
		public inkTextWidgetReference TextReplaceWidget
		{
			get
			{
				if (_textReplaceWidget == null)
				{
					_textReplaceWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textReplaceWidget", cr2w, this);
				}
				return _textReplaceWidget;
			}
			set
			{
				if (_textReplaceWidget == value)
				{
					return;
				}
				_textReplaceWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animateValueButton")] 
		public inkWidgetReference AnimateValueButton
		{
			get
			{
				if (_animateValueButton == null)
				{
					_animateValueButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animateValueButton", cr2w, this);
				}
				return _animateValueButton;
			}
			set
			{
				if (_animateValueButton == value)
				{
					return;
				}
				_animateValueButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animateValueWidget")] 
		public inkTextWidgetReference AnimateValueWidget
		{
			get
			{
				if (_animateValueWidget == null)
				{
					_animateValueWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "animateValueWidget", cr2w, this);
				}
				return _animateValueWidget;
			}
			set
			{
				if (_animateValueWidget == value)
				{
					return;
				}
				_animateValueWidget = value;
				PropertySet(this);
			}
		}

		public SampleUITextSystemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
