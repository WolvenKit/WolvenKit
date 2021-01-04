using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_SmartObject : animAnimFeature
	{
		[Ordinal(0)]  [RED("privateAnimationName")] public CName PrivateAnimationName { get; set; }
		[Ordinal(1)]  [RED("state")] public CInt32 State { get; set; }

		public animAnimFeature_SmartObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
