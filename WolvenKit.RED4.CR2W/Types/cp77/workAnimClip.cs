using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workAnimClip : workIEntry
	{
		[Ordinal(2)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(3)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }

		public workAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
