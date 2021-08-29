using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerBonus : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _fallingSpeed;

		[Ordinal(1)] 
		[RED("fallingSpeed")] 
		public CFloat FallingSpeed
		{
			get => GetProperty(ref _fallingSpeed);
			set => SetProperty(ref _fallingSpeed, value);
		}
	}
}
