using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextKiroshiAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;
		private CString _nativeText;
		private inkTextWidgetReference _preTranslatedTextWidget;
		private inkTextWidgetReference _postTranslatedTextWidget;
		private inkRichTextBoxWidgetReference _nativeTextWidget;
		private inkTextWidgetReference _translatedTextWidget;

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
		[RED("nativeText")] 
		public CString NativeText
		{
			get
			{
				if (_nativeText == null)
				{
					_nativeText = (CString) CR2WTypeManager.Create("String", "nativeText", cr2w, this);
				}
				return _nativeText;
			}
			set
			{
				if (_nativeText == value)
				{
					return;
				}
				_nativeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("preTranslatedTextWidget")] 
		public inkTextWidgetReference PreTranslatedTextWidget
		{
			get
			{
				if (_preTranslatedTextWidget == null)
				{
					_preTranslatedTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "preTranslatedTextWidget", cr2w, this);
				}
				return _preTranslatedTextWidget;
			}
			set
			{
				if (_preTranslatedTextWidget == value)
				{
					return;
				}
				_preTranslatedTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("postTranslatedTextWidget")] 
		public inkTextWidgetReference PostTranslatedTextWidget
		{
			get
			{
				if (_postTranslatedTextWidget == null)
				{
					_postTranslatedTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "postTranslatedTextWidget", cr2w, this);
				}
				return _postTranslatedTextWidget;
			}
			set
			{
				if (_postTranslatedTextWidget == value)
				{
					return;
				}
				_postTranslatedTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("nativeTextWidget")] 
		public inkRichTextBoxWidgetReference NativeTextWidget
		{
			get
			{
				if (_nativeTextWidget == null)
				{
					_nativeTextWidget = (inkRichTextBoxWidgetReference) CR2WTypeManager.Create("inkRichTextBoxWidgetReference", "nativeTextWidget", cr2w, this);
				}
				return _nativeTextWidget;
			}
			set
			{
				if (_nativeTextWidget == value)
				{
					return;
				}
				_nativeTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("translatedTextWidget")] 
		public inkTextWidgetReference TranslatedTextWidget
		{
			get
			{
				if (_translatedTextWidget == null)
				{
					_translatedTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "translatedTextWidget", cr2w, this);
				}
				return _translatedTextWidget;
			}
			set
			{
				if (_translatedTextWidget == value)
				{
					return;
				}
				_translatedTextWidget = value;
				PropertySet(this);
			}
		}

		public inkTextKiroshiAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
