using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopTransformInfo : CVariable
	{
		[Ordinal(0)]  [RED("rotation")] public EulerAngles Rotation { get; set; }
		[Ordinal(1)]  [RED("translation")] public Vector3 Translation { get; set; }

		public interopTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
