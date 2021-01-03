using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SHitStatusEffect : CVariable
	{
		[Ordinal(0)]  [RED("id")] public TweakDBID Id { get; set; }
		[Ordinal(1)]  [RED("stacks")] public CFloat Stacks { get; set; }

		public SHitStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
