using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitRepresentationResource : CResource
	{
		[Ordinal(1)] 
		[RED("representations")] 
		public CArray<gameHitShapeContainer> Representations
		{
			get => GetPropertyValue<CArray<gameHitShapeContainer>>();
			set => SetPropertyValue<CArray<gameHitShapeContainer>>(value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameHitRepresentationVisualTaggedOverride> Overrides
		{
			get => GetPropertyValue<CArray<gameHitRepresentationVisualTaggedOverride>>();
			set => SetPropertyValue<CArray<gameHitRepresentationVisualTaggedOverride>>(value);
		}

		public gameHitRepresentationResource()
		{
			Representations = new();
			Overrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
