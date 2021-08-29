using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasePerksMenuTooltipData : ATooltipData
	{
		private CHandle<PlayerDevelopmentDataManager> _manager;

		[Ordinal(0)] 
		[RED("manager")] 
		public CHandle<PlayerDevelopmentDataManager> Manager
		{
			get => GetProperty(ref _manager);
			set => SetProperty(ref _manager, value);
		}
	}
}
