using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneId : CVariable
	{
		[Ordinal(0)]  [RED("resPathHash")] public CUInt64 ResPathHash { get; set; }

		public scnSceneId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
