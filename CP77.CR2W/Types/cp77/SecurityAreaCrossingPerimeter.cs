using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaCrossingPerimeter : SecurityAreaEvent
	{
		[Ordinal(0)]  [RED("entered")] public CBool Entered { get; set; }

		public SecurityAreaCrossingPerimeter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
