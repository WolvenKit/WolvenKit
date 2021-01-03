using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentCullObject : CVariable
	{
		[Ordinal(0)]  [RED("CapsulePointA")] public Vector3 CapsulePointA { get; set; }
		[Ordinal(1)]  [RED("CapsulePointB")] public Vector3 CapsulePointB { get; set; }
		[Ordinal(2)]  [RED("CapsuleRadius")] public CFloat CapsuleRadius { get; set; }
		[Ordinal(3)]  [RED("NearestAnimBoneName")] public CName NearestAnimBoneName { get; set; }
		[Ordinal(4)]  [RED("NearestAnimIndex")] public CInt16 NearestAnimIndex { get; set; }
		[Ordinal(5)]  [RED("Plane")] public Plane Plane { get; set; }
		[Ordinal(6)]  [RED("Plane1")] public Plane Plane1 { get; set; }
		[Ordinal(7)]  [RED("RagdollBodyIndex")] public CUInt16 RagdollBodyIndex { get; set; }

		public entdismembermentCullObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
