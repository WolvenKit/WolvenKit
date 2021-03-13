using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceOnScreenEntry : CVariable
	{
		[Ordinal(0)] [RED("primaryKey")] public CUInt64 PrimaryKey { get; set; }
		[Ordinal(1)] [RED("secondaryKey")] public CString SecondaryKey { get; set; }
		[Ordinal(2)] [RED("femaleVariant")] public CString FemaleVariant { get; set; }
		[Ordinal(3)] [RED("maleVariant")] public CString MaleVariant { get; set; }

		public localizationPersistenceOnScreenEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
