using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animIKTargetRequest : RedBaseClass
	{
		private CFloat _weightPosition;
		private CFloat _weightOrientation;
		private CFloat _transitionIn;
		private CFloat _transitionOut;
		private CInt32 _priority;

		[Ordinal(0)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get => GetProperty(ref _weightPosition);
			set => SetProperty(ref _weightPosition, value);
		}

		[Ordinal(1)] 
		[RED("weightOrientation")] 
		public CFloat WeightOrientation
		{
			get => GetProperty(ref _weightOrientation);
			set => SetProperty(ref _weightOrientation, value);
		}

		[Ordinal(2)] 
		[RED("transitionIn")] 
		public CFloat TransitionIn
		{
			get => GetProperty(ref _transitionIn);
			set => SetProperty(ref _transitionIn, value);
		}

		[Ordinal(3)] 
		[RED("transitionOut")] 
		public CFloat TransitionOut
		{
			get => GetProperty(ref _transitionOut);
			set => SetProperty(ref _transitionOut, value);
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}
	}
}
