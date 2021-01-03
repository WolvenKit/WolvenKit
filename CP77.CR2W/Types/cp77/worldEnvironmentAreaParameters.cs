using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentAreaParameters : CResource
	{
		[Ordinal(0)]  [RED("renderAreaSettings")] public WorldRenderAreaSettings RenderAreaSettings { get; set; }
		[Ordinal(1)]  [RED("resaved")] public CBool Resaved { get; set; }

		public worldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
