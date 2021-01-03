using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkOnscreenVOData : CVariable
	{
		[Ordinal(0)]  [RED("text")] public CRUID Text { get; set; }

		public inkOnscreenVOData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
