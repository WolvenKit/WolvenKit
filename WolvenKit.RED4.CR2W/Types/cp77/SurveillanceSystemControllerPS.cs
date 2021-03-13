using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceSystemControllerPS : DeviceSystemBaseControllerPS
	{
		[Ordinal(105)] [RED("isRevealingEnemies")] public CBool IsRevealingEnemies { get; set; }

		public SurveillanceSystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
