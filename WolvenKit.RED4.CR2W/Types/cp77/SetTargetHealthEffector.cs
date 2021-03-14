using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTargetHealthEffector : gameEffector
	{
		[Ordinal(0)] [RED("healthValueToSet")] public CFloat HealthValueToSet { get; set; }

		public SetTargetHealthEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
