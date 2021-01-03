using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_ApplyEffector : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("effector")] public TweakDBID Effector { get; set; }

		public EffectExecutor_ApplyEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
