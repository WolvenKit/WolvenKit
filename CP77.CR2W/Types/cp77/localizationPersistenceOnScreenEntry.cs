using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceOnScreenEntry : CVariable
	{
		[Ordinal(0)]  [RED("femaleVariant")] public CString FemaleVariant { get; set; }
		[Ordinal(1)]  [RED("maleVariant")] public CString MaleVariant { get; set; }
		[Ordinal(2)]  [RED("primaryKey")] public CUInt64 PrimaryKey { get; set; }
		[Ordinal(3)]  [RED("secondaryKey")] public CString SecondaryKey { get; set; }

		public localizationPersistenceOnScreenEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
