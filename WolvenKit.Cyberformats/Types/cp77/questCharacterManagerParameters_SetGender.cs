using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetGender : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] [RED("params")] public CArray<questSetGender_NodeTypeParams> Params { get; set; }

		public questCharacterManagerParameters_SetGender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
