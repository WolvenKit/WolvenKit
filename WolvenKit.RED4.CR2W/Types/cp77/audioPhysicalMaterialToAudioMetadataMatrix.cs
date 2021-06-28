using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialToAudioMetadataMatrix : audioAudioMetadata
	{
		private CArray<audioAudioMaterialMetadataMapItem> _physicalToAudioMaterialAssignments;

		[Ordinal(1)] 
		[RED("physicalToAudioMaterialAssignments")] 
		public CArray<audioAudioMaterialMetadataMapItem> PhysicalToAudioMaterialAssignments
		{
			get => GetProperty(ref _physicalToAudioMaterialAssignments);
			set => SetProperty(ref _physicalToAudioMaterialAssignments, value);
		}

		public audioPhysicalMaterialToAudioMetadataMatrix(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
