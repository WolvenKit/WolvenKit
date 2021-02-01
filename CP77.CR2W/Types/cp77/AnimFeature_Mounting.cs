using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Mounting : animAnimFeature
	{
		[Ordinal(0)]  [RED("mountingState")] public CInt32 MountingState { get; set; }
		[Ordinal(1)]  [RED("parentSpeed")] public CFloat ParentSpeed { get; set; }

		public AnimFeature_Mounting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
