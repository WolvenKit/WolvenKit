using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneId : CVariable
	{
		[Ordinal(0)] [RED("resPathHash")] public CUInt64 ResPathHash { get; set; }

		public scnSceneId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
