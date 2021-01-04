using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeStruct : CVariable
	{
		[Ordinal(0)]  [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }
		[Ordinal(1)]  [RED("key")] public CName Key { get; set; }

		public gameNetrunnerPrototypeStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
