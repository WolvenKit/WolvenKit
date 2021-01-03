using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sampleImageChanger : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("imageName_1")] public CName ImageName_1 { get; set; }
		[Ordinal(1)]  [RED("imageName_2")] public CName ImageName_2 { get; set; }
		[Ordinal(2)]  [RED("imagePath")] public CName ImagePath { get; set; }
		[Ordinal(3)]  [RED("imageWidget")] public wCHandle<inkImageWidget> ImageWidget { get; set; }

		public sampleImageChanger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
