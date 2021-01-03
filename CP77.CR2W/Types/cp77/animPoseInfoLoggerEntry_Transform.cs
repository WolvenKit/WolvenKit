using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_Transform : animPoseInfoLoggerEntry
	{
		[Ordinal(0)]  [RED("logInModelSpace")] public CBool LogInModelSpace { get; set; }
		[Ordinal(1)]  [RED("transform")] public animTransformIndex Transform { get; set; }

		public animPoseInfoLoggerEntry_Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
