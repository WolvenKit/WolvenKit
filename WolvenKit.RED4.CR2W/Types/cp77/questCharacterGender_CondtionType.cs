using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterGender_CondtionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("gender")] public CName Gender { get; set; }

		public questCharacterGender_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
