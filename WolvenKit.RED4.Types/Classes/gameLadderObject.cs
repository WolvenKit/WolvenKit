using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLadderObject : gameObject
	{
		[Ordinal(40)] 
		[RED("heightOfBottomPart")] 
		public CFloat HeightOfBottomPart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
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
		}
	}
}
