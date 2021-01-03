using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyEffectorEffector : gameEffector
	{
		[Ordinal(0)]  [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(1)]  [RED("effectorToApply")] public TweakDBID EffectorToApply { get; set; }
		[Ordinal(2)]  [RED("target")] public entEntityID Target { get; set; }

		public ApplyEffectorEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
