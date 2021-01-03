using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpConveyorObject : gameObject
	{
		[Ordinal(0)]  [RED("ignoreZAxis")] public CBool IgnoreZAxis { get; set; }
		[Ordinal(1)]  [RED("rotationLerpFactor")] public CFloat RotationLerpFactor { get; set; }

		public cpConveyorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
