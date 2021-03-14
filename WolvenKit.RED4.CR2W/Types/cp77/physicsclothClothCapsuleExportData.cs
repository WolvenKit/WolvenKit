using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothClothCapsuleExportData : ISerializable
	{
		[Ordinal(0)] [RED("capsules")] public CArray<physicsclothExportedCapsule> Capsules { get; set; }

		public physicsclothClothCapsuleExportData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
