using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entHitRepresentationDataParameter : entEntityParameter
	{
		[Ordinal(0)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get => GetPropertyValue<CArray<gameHitRepresentationOverride>>();
			set => SetPropertyValue<CArray<gameHitRepresentationOverride>>(value);
		}

		public entHitRepresentationDataParameter()
		{
			HitRepresentationOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
