using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPhysicalMaterialToAudioMetadataMatrix : audioAudioMetadata
	{
		private CArray<audioAudioMaterialMetadataMapItem> _physicalToAudioMaterialAssignments;

		[Ordinal(1)] 
		[RED("physicalToAudioMaterialAssignments")] 
		public CArray<audioAudioMaterialMetadataMapItem> PhysicalToAudioMaterialAssignments
		{
			get => GetProperty(ref _physicalToAudioMaterialAssignments);
			set => SetProperty(ref _physicalToAudioMaterialAssignments, value);
		}
	}
}
