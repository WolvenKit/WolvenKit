using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerEnteredNewDistrictEvent : redEvent
	{
		[Ordinal(0)]  [RED("explosionRange")] public CFloat ExplosionRange { get; set; }
		[Ordinal(1)]  [RED("gunshotRange")] public CFloat GunshotRange { get; set; }

		public PlayerEnteredNewDistrictEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
