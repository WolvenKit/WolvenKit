using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AimingStateDecisions : UpperBodyTransition
	{
		[Ordinal(0)]  [RED("mouseZoomLevel")] public CFloat MouseZoomLevel { get; set; }

		public AimingStateDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
