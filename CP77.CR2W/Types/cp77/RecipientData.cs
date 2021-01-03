using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RecipientData : CVariable
	{
		[Ordinal(0)]  [RED("entryID")] public CInt32 EntryID { get; set; }
		[Ordinal(1)]  [RED("fuseID")] public CInt32 FuseID { get; set; }

		public RecipientData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
