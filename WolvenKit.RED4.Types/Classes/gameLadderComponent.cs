using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLadderComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("heightOfBottomPart")] 
		public CFloat HeightOfBottomPart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("enterOffset")] 
		public CFloat EnterOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameLadderComponent()
		{
			Name = "Component";
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
