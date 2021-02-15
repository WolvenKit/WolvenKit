using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TextSpawnerController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("amountOfRows")] public CInt32 AmountOfRows { get; set; }
		[Ordinal(2)] [RED("lineTextWidgetID")] public CName LineTextWidgetID { get; set; }
		[Ordinal(3)] [RED("texts")] public CArray<wCHandle<inkWidget>> Texts { get; set; }

		public TextSpawnerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
