using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectOnOwner : StatusEffectTasks
	{
		[Ordinal(0)]  [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }

		public ApplyStatusEffectOnOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
