using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerBonus : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] 
		[RED("fallingSpeed")] 
		public CFloat FallingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
