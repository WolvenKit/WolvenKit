using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPhysicalMaterialToAudioMetadataMatrix : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("physicalToAudioMaterialAssignments")] 
		public CArray<audioAudioMaterialMetadataMapItem> PhysicalToAudioMaterialAssignments
		{
			get => GetPropertyValue<CArray<audioAudioMaterialMetadataMapItem>>();
			set => SetPropertyValue<CArray<audioAudioMaterialMetadataMapItem>>(value);
		}

		public audioPhysicalMaterialToAudioMetadataMatrix()
		{
			PhysicalToAudioMaterialAssignments = new();
		}
	}
}
