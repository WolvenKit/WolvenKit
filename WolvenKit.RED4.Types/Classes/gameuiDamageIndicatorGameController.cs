using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDamageIndicatorGameController : gameuiHUDGameController
	{
		private CUInt8 _maxVisibleParts;

		[Ordinal(9)] 
		[RED("maxVisibleParts")] 
		public CUInt8 MaxVisibleParts
		{
			get => GetProperty(ref _maxVisibleParts);
			set => SetProperty(ref _maxVisibleParts, value);
		}
	}
}
