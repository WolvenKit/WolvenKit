using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiUIGameState : ISerializable
	{
		[Ordinal(0)]  [RED("uiData")] public CArray<CHandle<gameuiBaseUIData>> UiData { get; set; }

		public gameuiUIGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
