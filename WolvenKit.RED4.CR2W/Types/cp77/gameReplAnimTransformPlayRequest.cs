using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformPlayRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)] [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(3)] [RED("timesToPlay")] public CInt32 TimesToPlay { get; set; }

		public gameReplAnimTransformPlayRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
