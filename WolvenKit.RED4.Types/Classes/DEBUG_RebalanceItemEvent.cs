using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_RebalanceItemEvent : redEvent
	{
		private CFloat _reqLevel;

		[Ordinal(0)] 
		[RED("reqLevel")] 
		public CFloat ReqLevel
		{
			get => GetProperty(ref _reqLevel);
			set => SetProperty(ref _reqLevel, value);
		}
	}
}
