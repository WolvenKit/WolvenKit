using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)] [RED("envParams")] public rRef<worldEnvironmentAreaParameters> EnvParams { get; set; }
		[Ordinal(2)] [RED("blendTime")] public CFloat BlendTime { get; set; }

		public questPlayEnv_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
