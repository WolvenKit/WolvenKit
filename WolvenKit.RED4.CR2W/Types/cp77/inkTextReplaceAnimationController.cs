using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextReplaceAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;
		private CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> _widgetTextUsage;
		private LocalizationString _baseTextLocalized;
		private CString _targetText;
		private LocalizationString _targetTextLocalized;

		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get
			{
				if (_timeToSkip == null)
				{
					_timeToSkip = (CFloat) CR2WTypeManager.Create("Float", "timeToSkip", cr2w, this);
				}
				return _timeToSkip;
			}
			set
			{
				if (_timeToSkip == value)
				{
					return;
				}
				_timeToSkip = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("widgetTextUsage")] 
		public CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> WidgetTextUsage
		{
			get
			{
				if (_widgetTextUsage == null)
				{
					_widgetTextUsage = (CEnum<inkTextReplaceAnimationControllerWidgetTextUsage>) CR2WTypeManager.Create("inkTextReplaceAnimationControllerWidgetTextUsage", "widgetTextUsage", cr2w, this);
				}
				return _widgetTextUsage;
			}
			set
			{
				if (_widgetTextUsage == value)
				{
					return;
				}
				_widgetTextUsage = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("baseTextLocalized")] 
		public LocalizationString BaseTextLocalized
		{
			get
			{
				if (_baseTextLocalized == null)
				{
					_baseTextLocalized = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "baseTextLocalized", cr2w, this);
				}
				return _baseTextLocalized;
			}
			set
			{
				if (_baseTextLocalized == value)
				{
					return;
				}
				_baseTextLocalized = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("targetText")] 
		public CString TargetText
		{
			get
			{
				if (_targetText == null)
				{
					_targetText = (CString) CR2WTypeManager.Create("String", "targetText", cr2w, this);
				}
				return _targetText;
			}
			set
			{
				if (_targetText == value)
				{
					return;
				}
				_targetText = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("targetTextLocalized")] 
		public LocalizationString TargetTextLocalized
		{
			get
			{
				if (_targetTextLocalized == null)
				{
					_targetTextLocalized = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "targetTextLocalized", cr2w, this);
				}
				return _targetTextLocalized;
			}
			set
			{
				if (_targetTextLocalized == value)
				{
					return;
				}
				_targetTextLocalized = value;
				PropertySet(this);
			}
		}

		public inkTextReplaceAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
