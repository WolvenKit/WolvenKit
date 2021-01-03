using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OverloadDevice : ActionBool
	{
		[Ordinal(0)]  [RED("killDelay")] public CFloat KillDelay { get; set; }

		public OverloadDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
