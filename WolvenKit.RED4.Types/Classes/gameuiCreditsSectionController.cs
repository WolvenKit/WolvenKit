using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCreditsSectionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _sectionName;

		[Ordinal(1)] 
		[RED("sectionName")] 
		public inkTextWidgetReference SectionName
		{
			get => GetProperty(ref _sectionName);
			set => SetProperty(ref _sectionName, value);
		}
	}
}
