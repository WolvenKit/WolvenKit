using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGridDestructionEvent : redEvent
	{
		private CArrayFixedSize<CFloat> _state;
		private CArrayFixedSize<CFloat> _rawChange;
		private CArrayFixedSize<CFloat> _desiredChange;

		[Ordinal(0)] 
		[RED("state", 16)] 
		public CArrayFixedSize<CFloat> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("rawChange", 16)] 
		public CArrayFixedSize<CFloat> RawChange
		{
			get => GetProperty(ref _rawChange);
			set => SetProperty(ref _rawChange, value);
		}

		[Ordinal(2)] 
		[RED("desiredChange", 16)] 
		public CArrayFixedSize<CFloat> DesiredChange
		{
			get => GetProperty(ref _desiredChange);
			set => SetProperty(ref _desiredChange, value);
		}
	}
}
