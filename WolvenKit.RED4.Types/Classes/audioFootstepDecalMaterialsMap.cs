using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFootstepDecalMaterialsMap : audioAudioMetadata
	{
		private CFloat _closestDecalDetectionRadius;
		private CArray<audioFootstepDecalMaterialEntry> _entries;

		[Ordinal(1)] 
		[RED("closestDecalDetectionRadius")] 
		public CFloat ClosestDecalDetectionRadius
		{
			get => GetProperty(ref _closestDecalDetectionRadius);
			set => SetProperty(ref _closestDecalDetectionRadius, value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<audioFootstepDecalMaterialEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public audioFootstepDecalMaterialsMap()
		{
			_closestDecalDetectionRadius = 2.000000F;
		}
	}
}
