using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipModEntryController : inkWidgetLogicController
	{
		private inkTextWidgetReference _modName;

		[Ordinal(1)] 
		[RED("modName")] 
		public inkTextWidgetReference ModName
		{
			get => GetProperty(ref _modName);
			set => SetProperty(ref _modName, value);
		}
	}
}
