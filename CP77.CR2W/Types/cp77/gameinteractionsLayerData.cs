using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLayerData : CVariable
	{
		[Ordinal(0)]  [RED("tag")] public CName Tag { get; set; }

		public gameinteractionsLayerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
