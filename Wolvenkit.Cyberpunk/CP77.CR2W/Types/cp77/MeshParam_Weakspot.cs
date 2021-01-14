using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeshParam_Weakspot : animAnimFeature
	{
		[Ordinal(0)]  [RED("hidden")] public CInt32 Hidden { get; set; }

		public MeshParam_Weakspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
