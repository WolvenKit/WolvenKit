using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioRigMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("defaultBone")] public CName DefaultBone { get; set; }
		[Ordinal(1)]  [RED("positionBones")] public CArray<CName> PositionBones { get; set; }

		public audioRigMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
