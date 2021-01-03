using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkGridItem : CVariable
	{
		[Ordinal(0)]  [RED("rootIdx")] public CUInt32 RootIdx { get; set; }

		public inkGridItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
