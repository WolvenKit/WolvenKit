using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsclothClothCapsuleExportData : ISerializable
	{
		[Ordinal(0)]  [RED("capsules")] public CArray<physicsclothExportedCapsule> Capsules { get; set; }

		public physicsclothClothCapsuleExportData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
