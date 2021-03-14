using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithDistance : ModifyDamageEffector
	{
		[Ordinal(2)] [RED("increaseWithDistance")] public CBool IncreaseWithDistance { get; set; }
		[Ordinal(3)] [RED("percentMult")] public CFloat PercentMult { get; set; }
		[Ordinal(4)] [RED("unitThreshold")] public CFloat UnitThreshold { get; set; }

		public ModifyDamageWithDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
