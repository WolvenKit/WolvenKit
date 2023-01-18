using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleGridDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state", 16)] 
		public CArrayFixedSize<CFloat> State
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("rawChange", 16)] 
		public CArrayFixedSize<CFloat> RawChange
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("desiredChange", 16)] 
		public CArrayFixedSize<CFloat> DesiredChange
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		public vehicleGridDestructionEvent()
		{
			State = new(16);
			RawChange = new(16);
			DesiredChange = new(16);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
