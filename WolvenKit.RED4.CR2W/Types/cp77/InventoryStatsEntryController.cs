using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsEntryController : inkWidgetLogicController
	{
		private inkImageWidgetReference _iconWidget;
		private inkTextWidgetReference _labelWidget;
		private inkTextWidgetReference _valueWidget;

		[Ordinal(1)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetProperty(ref _iconWidget);
			set => SetProperty(ref _iconWidget, value);
		}

		[Ordinal(2)] 
		[RED("labelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get => GetProperty(ref _labelWidget);
			set => SetProperty(ref _labelWidget, value);
		}

		[Ordinal(3)] 
		[RED("valueWidget")] 
		public inkTextWidgetReference ValueWidget
		{
			get => GetProperty(ref _valueWidget);
			set => SetProperty(ref _valueWidget, value);
		}

		public InventoryStatsEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
