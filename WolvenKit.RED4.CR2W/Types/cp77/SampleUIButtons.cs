using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUIButtons : inkWidgetLogicController
	{
		private inkWidgetReference _button;
		private inkWidgetReference _toggle1;
		private inkWidgetReference _toggle2;
		private inkWidgetReference _toggle3;
		private inkWidgetReference _radioGroup;
		private inkTextWidgetReference _text;

		[Ordinal(1)] 
		[RED("Button")] 
		public inkWidgetReference Button
		{
			get => GetProperty(ref _button);
			set => SetProperty(ref _button, value);
		}

		[Ordinal(2)] 
		[RED("Toggle1")] 
		public inkWidgetReference Toggle1
		{
			get => GetProperty(ref _toggle1);
			set => SetProperty(ref _toggle1, value);
		}

		[Ordinal(3)] 
		[RED("Toggle2")] 
		public inkWidgetReference Toggle2
		{
			get => GetProperty(ref _toggle2);
			set => SetProperty(ref _toggle2, value);
		}

		[Ordinal(4)] 
		[RED("Toggle3")] 
		public inkWidgetReference Toggle3
		{
			get => GetProperty(ref _toggle3);
			set => SetProperty(ref _toggle3, value);
		}

		[Ordinal(5)] 
		[RED("RadioGroup")] 
		public inkWidgetReference RadioGroup
		{
			get => GetProperty(ref _radioGroup);
			set => SetProperty(ref _radioGroup, value);
		}

		[Ordinal(6)] 
		[RED("Text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		public SampleUIButtons(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
