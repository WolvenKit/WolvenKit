using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("data")] public gamemappinsMappinData Data { get; set; }

		public gamemappinsMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
