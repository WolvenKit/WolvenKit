using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GiveRewardEffector : gameEffector
	{
		[Ordinal(0)] [RED("reward")] public TweakDBID Reward { get; set; }
		[Ordinal(1)] [RED("target")] public entEntityID Target { get; set; }

		public GiveRewardEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
