using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyorObject : gameObject
	{
		[Ordinal(40)] [RED("rotationLerpFactor")] public CFloat RotationLerpFactor { get; set; }
		[Ordinal(41)] [RED("ignoreZAxis")] public CBool IgnoreZAxis { get; set; }

		public cpConveyorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
