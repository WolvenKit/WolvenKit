using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameComponent : entIComponent
	{
		[Ordinal(3)] [RED("persistentState")] public CHandle<gamePersistentState> PersistentState { get; set; }

		public gameComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
