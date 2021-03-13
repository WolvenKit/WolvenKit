using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerEnteredNewDistrictEvent : redEvent
	{
		[Ordinal(0)] [RED("gunshotRange")] public CFloat GunshotRange { get; set; }
		[Ordinal(1)] [RED("explosionRange")] public CFloat ExplosionRange { get; set; }

		public PlayerEnteredNewDistrictEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
