using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuLabelContentContainer : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _desiredSizeWrapper;
		private inkBorderWidgetReference _border;
		private CInt32 _carouselPosition;
		private CString _labelName;
		private MenuData _data;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("desiredSizeWrapper")] 
		public inkWidgetReference DesiredSizeWrapper
		{
			get => GetProperty(ref _desiredSizeWrapper);
			set => SetProperty(ref _desiredSizeWrapper, value);
		}

		[Ordinal(4)] 
		[RED("border")] 
		public inkBorderWidgetReference Border
		{
			get => GetProperty(ref _border);
			set => SetProperty(ref _border, value);
		}

		[Ordinal(5)] 
		[RED("carouselPosition")] 
		public CInt32 CarouselPosition
		{
			get => GetProperty(ref _carouselPosition);
			set => SetProperty(ref _carouselPosition, value);
		}

		[Ordinal(6)] 
		[RED("labelName")] 
		public CString LabelName
		{
			get => GetProperty(ref _labelName);
			set => SetProperty(ref _labelName, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public MenuData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public HubMenuLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
