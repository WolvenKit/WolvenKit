using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareChargeEvents : LeftHandCyberwareEventsTransition
	{
		[Ordinal(0)]  [RED("chargeModeAim")] public CHandle<gameweaponAnimFeature_AimPlayer> ChargeModeAim { get; set; }
		[Ordinal(1)]  [RED("leftHandObject")] public wCHandle<gameweaponObject> LeftHandObject { get; set; }

		public LeftHandCyberwareChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
