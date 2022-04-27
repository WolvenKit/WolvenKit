using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ParticleDamage : ISerializable
	{
		[Ordinal(0)] 
		[RED("boundingBoxes")] 
		public CArray<Box> BoundingBoxes
		{
			get => GetPropertyValue<CArray<Box>>();
			set => SetPropertyValue<CArray<Box>>(value);
		}

		public ParticleDamage()
		{
			BoundingBoxes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
