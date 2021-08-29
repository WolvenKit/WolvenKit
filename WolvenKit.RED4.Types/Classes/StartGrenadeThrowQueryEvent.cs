using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StartGrenadeThrowQueryEvent : redEvent
	{
		private gameGrenadeThrowQueryParams _queryParams;

		[Ordinal(0)] 
		[RED("queryParams")] 
		public gameGrenadeThrowQueryParams QueryParams
		{
			get => GetProperty(ref _queryParams);
			set => SetProperty(ref _queryParams, value);
		}
	}
}
