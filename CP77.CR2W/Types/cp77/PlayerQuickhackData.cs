using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerQuickhackData : CVariable
	{
		[Ordinal(0)]  [RED("actionPenetration")] public CFloat ActionPenetration { get; set; }
		[Ordinal(1)]  [RED("actionTweak")] public TweakDBID ActionTweak { get; set; }
		[Ordinal(2)]  [RED("quality")] public CInt32 Quality { get; set; }

		public PlayerQuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
