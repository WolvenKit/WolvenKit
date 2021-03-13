using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkOnscreenVOData : CVariable
	{
		[Ordinal(0)] [RED("text")] public CRUID Text { get; set; }

		public inkOnscreenVOData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
