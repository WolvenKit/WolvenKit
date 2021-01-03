using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animHipsIkRequest : CVariable
	{
		[Ordinal(0)]  [RED("hipsTransformIndex")] public animTransformIndex HipsTransformIndex { get; set; }
		[Ordinal(1)]  [RED("leftFootTransformIndex")] public animTransformIndex LeftFootTransformIndex { get; set; }
		[Ordinal(2)]  [RED("leftLegIkChain")] public CName LeftLegIkChain { get; set; }
		[Ordinal(3)]  [RED("rightFootTransformIndex")] public animTransformIndex RightFootTransformIndex { get; set; }
		[Ordinal(4)]  [RED("rightLegIkChain")] public CName RightLegIkChain { get; set; }

		public animHipsIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
