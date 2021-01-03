using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TextSpawnerController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("amountOfRows")] public CInt32 AmountOfRows { get; set; }
		[Ordinal(1)]  [RED("lineTextWidgetID")] public CName LineTextWidgetID { get; set; }
		[Ordinal(2)]  [RED("texts")] public CArray<wCHandle<inkWidget>> Texts { get; set; }

		public TextSpawnerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
