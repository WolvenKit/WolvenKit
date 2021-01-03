using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ReadIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("ikChain")] public CName IkChain { get; set; }
		[Ordinal(1)]  [RED("outTransform")] public animTransformIndex OutTransform { get; set; }

		public animAnimNode_ReadIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
