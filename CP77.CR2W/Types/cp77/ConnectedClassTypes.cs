using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ConnectedClassTypes : CVariable
	{
		[Ordinal(0)]  [RED("puppet")] public CBool Puppet { get; set; }
		[Ordinal(1)]  [RED("securityTurret")] public CBool SecurityTurret { get; set; }
		[Ordinal(2)]  [RED("surveillanceCamera")] public CBool SurveillanceCamera { get; set; }

		public ConnectedClassTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
