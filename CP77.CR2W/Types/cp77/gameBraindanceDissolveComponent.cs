using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBraindanceDissolveComponent : entIComponent
	{
		[Ordinal(0)]  [RED("dissolveRadius")] public CFloat DissolveRadius { get; set; }

		public gameBraindanceDissolveComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
