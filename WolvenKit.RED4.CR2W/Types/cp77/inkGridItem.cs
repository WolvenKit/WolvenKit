using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridItem : CVariable
	{
		[Ordinal(0)] [RED("rootIdx")] public CUInt32 RootIdx { get; set; }

		public inkGridItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
