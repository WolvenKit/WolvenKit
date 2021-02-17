using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeleteEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("setName")] public CString SetName { get; set; }

		public DeleteEquipmentSetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
