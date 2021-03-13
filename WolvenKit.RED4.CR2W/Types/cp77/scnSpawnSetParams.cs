using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSpawnSetParams : CVariable
	{
		[Ordinal(0)] [RED("reference")] public NodeRef Reference { get; set; }
		[Ordinal(1)] [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(2)] [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }

		public scnSpawnSetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
