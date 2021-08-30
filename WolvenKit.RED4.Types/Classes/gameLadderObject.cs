using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLadderObject : gameObject
	{
		private CFloat _heightOfBottomPart;
		private CFloat _exitStepTop;
		private CFloat _verticalStepTop;
		private CFloat _exitStepBottom;
		private CFloat _verticalStepBottom;
		private CFloat _exitStepJump;
		private CFloat _verticalStepJump;
		private CFloat _enterOffset;

		[Ordinal(40)] 
		[RED("heightOfBottomPart")] 
		public CFloat HeightOfBottomPart
		{
			get => GetProperty(ref _heightOfBottomPart);
			set => SetProperty(ref _heightOfBottomPart, value);
		}

		[Ordinal(41)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get => GetProperty(ref _exitStepTop);
			set => SetProperty(ref _exitStepTop, value);
		}

		[Ordinal(42)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get => GetProperty(ref _verticalStepTop);
			set => SetProperty(ref _verticalStepTop, value);
		}

		[Ordinal(43)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get => GetProperty(ref _exitStepBottom);
			set => SetProperty(ref _exitStepBottom, value);
		}

		[Ordinal(44)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get => GetProperty(ref _verticalStepBottom);
			set => SetProperty(ref _verticalStepBottom, value);
		}

		[Ordinal(45)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get => GetProperty(ref _exitStepJump);
			set => SetProperty(ref _exitStepJump, value);
		}

		[Ordinal(46)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get => GetProperty(ref _verticalStepJump);
			set => SetProperty(ref _verticalStepJump, value);
		}

		[Ordinal(47)] 
		[RED("enterOffset")] 
		public CFloat EnterOffset
		{
			get => GetProperty(ref _enterOffset);
			set => SetProperty(ref _enterOffset, value);
		}

		public gameLadderObject()
		{
			_heightOfBottomPart = 3.700000F;
			_exitStepTop = -1.000000F;
			_verticalStepTop = -1.000000F;
			_exitStepBottom = 0.600000F;
			_verticalStepBottom = 0.400000F;
			_exitStepJump = 0.600000F;
			_verticalStepJump = 0.200000F;
			_enterOffset = 0.500000F;
		}
	}
}
