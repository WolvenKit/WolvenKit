using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialArea : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("bracketID")] public CName BracketID { get; set; }

		public gameuiTutorialArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
