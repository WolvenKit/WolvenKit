using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animHipsIkRequest : CVariable
	{
		[Ordinal(0)] [RED("leftLegIkChain")] public CName LeftLegIkChain { get; set; }
		[Ordinal(1)] [RED("rightLegIkChain")] public CName RightLegIkChain { get; set; }
		[Ordinal(2)] [RED("hipsTransformIndex")] public animTransformIndex HipsTransformIndex { get; set; }
		[Ordinal(3)] [RED("leftFootTransformIndex")] public animTransformIndex LeftFootTransformIndex { get; set; }
		[Ordinal(4)] [RED("rightFootTransformIndex")] public animTransformIndex RightFootTransformIndex { get; set; }

		public animHipsIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
