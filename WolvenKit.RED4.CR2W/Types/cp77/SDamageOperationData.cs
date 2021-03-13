using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDamageOperationData : CVariable
	{
		[Ordinal(0)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(1)] [RED("offset")] public Vector4 Offset { get; set; }
		[Ordinal(2)] [RED("damageType")] public TweakDBID DamageType { get; set; }

		public SDamageOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
