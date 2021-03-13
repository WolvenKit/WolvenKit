using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerQuestClue : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("CategoryTextRef")] public inkTextWidgetReference CategoryTextRef { get; set; }
		[Ordinal(2)] [RED("DescriptionTextRef")] public inkTextWidgetReference DescriptionTextRef { get; set; }
		[Ordinal(3)] [RED("IconRef")] public inkImageWidgetReference IconRef { get; set; }

		public ScannerQuestClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
