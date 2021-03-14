using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerRange : inkSettingsSelectorController
	{
		private inkTextWidgetReference _valueText;
		private inkWidgetReference _leftArrow;
		private inkWidgetReference _rightArrow;
		private inkWidgetReference _progressBar;

		[Ordinal(15)] 
		[RED("ValueText")] 
		public inkTextWidgetReference ValueText
		{
			get
			{
				if (_valueText == null)
				{
					_valueText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ValueText", cr2w, this);
				}
				return _valueText;
			}
			set
			{
				if (_valueText == value)
				{
					return;
				}
				_valueText = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get
			{
				if (_leftArrow == null)
				{
					_leftArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LeftArrow", cr2w, this);
				}
				return _leftArrow;
			}
			set
			{
				if (_leftArrow == value)
				{
					return;
				}
				_leftArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get
			{
				if (_rightArrow == null)
				{
					_rightArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RightArrow", cr2w, this);
				}
				return _rightArrow;
			}
			set
			{
				if (_rightArrow == value)
				{
					return;
				}
				_rightArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ProgressBar")] 
		public inkWidgetReference ProgressBar
		{
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ProgressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		public SettingsSelectorControllerRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
