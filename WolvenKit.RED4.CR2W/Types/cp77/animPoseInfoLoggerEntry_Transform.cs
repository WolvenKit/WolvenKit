using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_Transform : animPoseInfoLoggerEntry
	{
		[Ordinal(0)] [RED("transform")] public animTransformIndex Transform { get; set; }
		[Ordinal(1)] [RED("logInModelSpace")] public CBool LogInModelSpace { get; set; }

		public animPoseInfoLoggerEntry_Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
