using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePlayerProximityPrereq : gameIPrereq
	{
		[Ordinal(0)]  [RED("squaredRange")] public CFloat SquaredRange { get; set; }

		public gamePlayerProximityPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
