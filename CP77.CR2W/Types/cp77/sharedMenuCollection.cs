using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sharedMenuCollection : CVariable
	{
		[Ordinal(0)]  [RED("items")] public CArray<sharedMenuItem> Items { get; set; }

		public sharedMenuCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
