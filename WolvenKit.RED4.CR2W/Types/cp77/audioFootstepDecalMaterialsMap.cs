using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("closestDecalDetectionRadius")] public CFloat ClosestDecalDetectionRadius { get; set; }
		[Ordinal(2)] [RED("entries")] public CArray<audioFootstepDecalMaterialEntry> Entries { get; set; }

		public audioFootstepDecalMaterialsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
