using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLadderObject : gameObject
	{
		[Ordinal(35)] 
		[RED("heightOfBottomPart")] 
		public CFloat HeightOfBottomPart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("enterOffset")] 
		public CFloat EnterOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameLadderObject()
		{
			HeightOfBottomPart = 3.700000F;
			ExitStepTop = -1.000000F;
			VerticalStepTop = -1.000000F;
			ExitStepBottom = 0.600000F;
			VerticalStepBottom = 0.400000F;
			ExitStepJump = 0.600000F;
			VerticalStepJump = 0.200000F;
			EnterOffset = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
