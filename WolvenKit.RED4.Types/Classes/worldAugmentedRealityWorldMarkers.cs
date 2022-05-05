using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAugmentedRealityWorldMarkers : ISerializable
	{
		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<Transform> Transforms
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		public worldAugmentedRealityWorldMarkers()
		{
			Transforms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
