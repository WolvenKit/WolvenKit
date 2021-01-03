using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SInternetData : CVariable
	{
		[Ordinal(0)]  [RED("startingPage")] public CString StartingPage { get; set; }

		public SInternetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
