using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeaponMalfunctionHudEffector : gameEffector
	{
		[Ordinal(0)]  [RED("bb")] public CHandle<gameIBlackboard> Bb { get; set; }

		public WeaponMalfunctionHudEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
