using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entIAttachment : ISerializable
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<entIComponent> Source
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public CWeakHandle<entIComponent> Destination
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		public entIAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
