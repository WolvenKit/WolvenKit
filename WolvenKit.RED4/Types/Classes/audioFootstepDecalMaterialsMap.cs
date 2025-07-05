using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFootstepDecalMaterialsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("closestDecalDetectionRadius")] 
		public CFloat ClosestDecalDetectionRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<audioFootstepDecalMaterialEntry> Entries
		{
			get => GetPropertyValue<CArray<audioFootstepDecalMaterialEntry>>();
			set => SetPropertyValue<CArray<audioFootstepDecalMaterialEntry>>(value);
		}

		public audioFootstepDecalMaterialsMap()
		{
			ClosestDecalDetectionRadius = 2.000000F;
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
