using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class senseSimpleBox : senseIShape
	{
		[Ordinal(0)]  [RED("box")] public Box Box { get; set; }

		public senseSimpleBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
