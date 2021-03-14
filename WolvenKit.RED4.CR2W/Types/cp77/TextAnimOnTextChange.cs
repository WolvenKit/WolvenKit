using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TextAnimOnTextChange : inkWidgetLogicController
	{
		private inkTextWidgetReference _textField;
		private CName _animationName;
		private CHandle<inkanimDefinition> _blinkAnim;
		private CHandle<inkanimDefinition> _scaleAnim;
		private CString _bufferedValue;

		[Ordinal(1)] 
		[RED("textField")] 
		public inkTextWidgetReference TextField
		{
			get
			{
				if (_textField == null)
				{
					_textField = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textField", cr2w, this);
				}
				return _textField;
			}
			set
			{
				if (_textField == value)
				{
					return;
				}
				_textField = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("BlinkAnim")] 
		public CHandle<inkanimDefinition> BlinkAnim
		{
			get
			{
				if (_blinkAnim == null)
				{
					_blinkAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "BlinkAnim", cr2w, this);
				}
				return _blinkAnim;
			}
			set
			{
				if (_blinkAnim == value)
				{
					return;
				}
				_blinkAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ScaleAnim")] 
		public CHandle<inkanimDefinition> ScaleAnim
		{
			get
			{
				if (_scaleAnim == null)
				{
					_scaleAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "ScaleAnim", cr2w, this);
				}
				return _scaleAnim;
			}
			set
			{
				if (_scaleAnim == value)
				{
					return;
				}
				_scaleAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bufferedValue")] 
		public CString BufferedValue
		{
			get
			{
				if (_bufferedValue == null)
				{
					_bufferedValue = (CString) CR2WTypeManager.Create("String", "bufferedValue", cr2w, this);
				}
				return _bufferedValue;
			}
			set
			{
				if (_bufferedValue == value)
				{
					return;
				}
				_bufferedValue = value;
				PropertySet(this);
			}
		}

		public TextAnimOnTextChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
