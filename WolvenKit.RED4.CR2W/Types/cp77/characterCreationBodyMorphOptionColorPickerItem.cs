using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPickerItem : inkWidgetLogicController
	{
		private inkWidgetReference _background;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _foreground;
		private inkWidgetReference _selectionMark;

		[Ordinal(1)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("foreground")] 
		public inkWidgetReference Foreground
		{
			get => GetProperty(ref _foreground);
			set => SetProperty(ref _foreground, value);
		}

		[Ordinal(4)] 
		[RED("selectionMark")] 
		public inkWidgetReference SelectionMark
		{
			get => GetProperty(ref _selectionMark);
			set => SetProperty(ref _selectionMark, value);
		}

		public characterCreationBodyMorphOptionColorPickerItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
