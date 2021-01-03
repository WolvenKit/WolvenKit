using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformPlayRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(0)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(2)]  [RED("timesToPlay")] public CInt32 TimesToPlay { get; set; }

		public gameReplAnimTransformPlayRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
