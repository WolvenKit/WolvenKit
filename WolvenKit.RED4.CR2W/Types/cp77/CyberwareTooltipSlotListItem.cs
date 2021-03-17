using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipSlotListItem : AGenericTooltipController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _desc;
		private CHandle<CyberwareSlotTooltipData> _data;

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(4)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<CyberwareSlotTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public CyberwareTooltipSlotListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
