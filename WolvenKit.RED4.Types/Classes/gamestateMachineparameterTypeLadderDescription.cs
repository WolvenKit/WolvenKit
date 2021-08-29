using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineparameterTypeLadderDescription : IScriptable
	{
		private Vector4 _position;
		private Vector4 _normal;
		private Vector4 _up;
		private CFloat _topHeightFromPosition;
		private CFloat _exitStepTop;
		private CFloat _verticalStepTop;
		private CFloat _exitStepBottom;
		private CFloat _verticalStepBottom;
		private CFloat _exitStepJump;
		private CFloat _verticalStepJump;
		private CFloat _enterOffset;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get => GetProperty(ref _normal);
			set => SetProperty(ref _normal, value);
		}

		[Ordinal(2)] 
		[RED("up")] 
		public Vector4 Up
		{
			get => GetProperty(ref _up);
			set => SetProperty(ref _up, value);
		}

		[Ordinal(3)] 
		[RED("topHeightFromPosition")] 
		public CFloat TopHeightFromPosition
		{
			get => GetProperty(ref _topHeightFromPosition);
			set => SetProperty(ref _topHeightFromPosition, value);
		}

		[Ordinal(4)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get => GetProperty(ref _exitStepTop);
			set => SetProperty(ref _exitStepTop, value);
		}

		[Ordinal(5)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get => GetProperty(ref _verticalStepTop);
			set => SetProperty(ref _verticalStepTop, value);
		}

		[Ordinal(6)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get => GetProperty(ref _exitStepBottom);
			set => SetProperty(ref _exitStepBottom, value);
		}

		[Ordinal(7)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get => GetProperty(ref _verticalStepBottom);
			set => SetProperty(ref _verticalStepBottom, value);
		}

		[Ordinal(8)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get => GetProperty(ref _exitStepJump);
			set => SetProperty(ref _exitStepJump, value);
		}

		[Ordinal(9)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get => GetProperty(ref _verticalStepJump);
			set => SetProperty(ref _verticalStepJump, value);
		}

		[Ordinal(10)] 
		[RED("enterOffset")] 
		public CFloat EnterOffset
		{
			get => GetProperty(ref _enterOffset);
			set => SetProperty(ref _enterOffset, value);
		}
	}
}
