using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownStorageID : CVariable
	{
		[Ordinal(0)] [RED("ID")] public CUInt32 ID { get; set; }
		[Ordinal(1)] [RED("isValid")] public CEnum<EBOOL> IsValid { get; set; }

		public CooldownStorageID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
