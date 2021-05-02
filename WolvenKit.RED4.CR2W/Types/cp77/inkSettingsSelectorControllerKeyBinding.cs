using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorControllerKeyBinding : inkSettingsSelectorController
	{
		private inkRichTextBoxWidgetReference _text;
		private inkWidgetReference _buttonRef;
		private inkWidgetReference _editView;
		private CFloat _editOpacity;

		[Ordinal(15)] 
		[RED("text")] 
		public inkRichTextBoxWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(16)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}

		[Ordinal(17)] 
		[RED("editView")] 
		public inkWidgetReference EditView
		{
			get => GetProperty(ref _editView);
			set => SetProperty(ref _editView, value);
		}

		[Ordinal(18)] 
		[RED("editOpacity")] 
		public CFloat EditOpacity
		{
			get => GetProperty(ref _editOpacity);
			set => SetProperty(ref _editOpacity, value);
		}

		public inkSettingsSelectorControllerKeyBinding(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
