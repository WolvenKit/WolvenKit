using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HighlightObjectEffector : gameEffector
	{
		[Ordinal(0)]  [RED("reason")] public CName Reason { get; set; }

		public HighlightObjectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
