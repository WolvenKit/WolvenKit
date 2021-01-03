using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyObjectActionEffector : gameEffector
	{
		[Ordinal(0)]  [RED("actionID")] public TweakDBID ActionID { get; set; }
		[Ordinal(1)]  [RED("probability")] public CFloat Probability { get; set; }
		[Ordinal(2)]  [RED("triggered")] public CBool Triggered { get; set; }

		public ApplyObjectActionEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
