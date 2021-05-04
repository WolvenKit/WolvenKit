using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationGenderBackstoryPathHeader : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _desc;
		private inkWidgetReference _bg;
		private CColor _selectedColor;
		private CColor _unSelectedColor;
		private CColor _textSelectedColor;
		private CColor _textUnselectedColor;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(3)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetProperty(ref _bg);
			set => SetProperty(ref _bg, value);
		}

		[Ordinal(4)] 
		[RED("selectedColor")] 
		public CColor SelectedColor
		{
			get => GetProperty(ref _selectedColor);
			set => SetProperty(ref _selectedColor, value);
		}

		[Ordinal(5)] 
		[RED("unSelectedColor")] 
		public CColor UnSelectedColor
		{
			get => GetProperty(ref _unSelectedColor);
			set => SetProperty(ref _unSelectedColor, value);
		}

		[Ordinal(6)] 
		[RED("textSelectedColor")] 
		public CColor TextSelectedColor
		{
			get => GetProperty(ref _textSelectedColor);
			set => SetProperty(ref _textSelectedColor, value);
		}

		[Ordinal(7)] 
		[RED("textUnselectedColor")] 
		public CColor TextUnselectedColor
		{
			get => GetProperty(ref _textUnselectedColor);
			set => SetProperty(ref _textUnselectedColor, value);
		}

		public CharacterCreationGenderBackstoryPathHeader(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
