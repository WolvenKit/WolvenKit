using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
