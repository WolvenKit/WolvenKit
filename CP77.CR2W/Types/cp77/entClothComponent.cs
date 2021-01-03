using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entClothComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(1)]  [RED("mesh")] public rRef<CMesh> Mesh { get; set; }

		public entClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
