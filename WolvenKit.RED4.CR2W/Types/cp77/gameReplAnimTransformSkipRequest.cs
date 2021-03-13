using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSkipRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)] [RED("skipTime")] public CFloat SkipTime { get; set; }

		public gameReplAnimTransformSkipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
