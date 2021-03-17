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
			get => GetProperty(ref _textField);
			set => SetProperty(ref _textField, value);
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(3)] 
		[RED("BlinkAnim")] 
		public CHandle<inkanimDefinition> BlinkAnim
		{
			get => GetProperty(ref _blinkAnim);
			set => SetProperty(ref _blinkAnim, value);
		}

		[Ordinal(4)] 
		[RED("ScaleAnim")] 
		public CHandle<inkanimDefinition> ScaleAnim
		{
			get => GetProperty(ref _scaleAnim);
			set => SetProperty(ref _scaleAnim, value);
		}

		[Ordinal(5)] 
		[RED("bufferedValue")] 
		public CString BufferedValue
		{
			get => GetProperty(ref _bufferedValue);
			set => SetProperty(ref _bufferedValue, value);
		}

		public TextAnimOnTextChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
