using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_IK : animAnimFeature
	{
		[Ordinal(0)]  [RED("normal")] public Vector4 Normal { get; set; }
		[Ordinal(1)]  [RED("point")] public Vector4 Point { get; set; }
		[Ordinal(2)]  [RED("weight")] public CFloat Weight { get; set; }

		public animAnimFeature_IK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
