using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialToAudioMetadataMatrix : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("physicalToAudioMaterialAssignments")] public CArray<audioAudioMaterialMetadataMapItem> PhysicalToAudioMaterialAssignments { get; set; }

		public audioPhysicalMaterialToAudioMetadataMatrix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
