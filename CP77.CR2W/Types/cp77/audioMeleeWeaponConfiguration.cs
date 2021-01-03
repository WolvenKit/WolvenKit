using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponConfiguration : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("blockSound")] public audioMeleeSound BlockSound { get; set; }
		[Ordinal(1)]  [RED("detailSound")] public audioMeleeSound DetailSound { get; set; }
		[Ordinal(2)]  [RED("equipSound")] public audioMeleeSound EquipSound { get; set; }
		[Ordinal(3)]  [RED("fastWhoosh")] public audioMeleeSound FastWhoosh { get; set; }
		[Ordinal(4)]  [RED("handlingSound")] public audioMeleeSound HandlingSound { get; set; }
		[Ordinal(5)]  [RED("meleeSoundsByHitPerMaterialType")] public CHandle<audioMeleeHitTypeMeleeSoundDictionary> MeleeSoundsByHitPerMaterialType { get; set; }
		[Ordinal(6)]  [RED("meleeWeaponConfigurationsByRigTypeMap")] public audioMeleeRigTypeMeleeWeaponConfigurationMap MeleeWeaponConfigurationsByRigTypeMap { get; set; }
		[Ordinal(7)]  [RED("normalWhoosh")] public audioMeleeSound NormalWhoosh { get; set; }
		[Ordinal(8)]  [RED("parrySound")] public audioMeleeSound ParrySound { get; set; }
		[Ordinal(9)]  [RED("slowWhoosh")] public audioMeleeSound SlowWhoosh { get; set; }
		[Ordinal(10)]  [RED("unequipSound")] public audioMeleeSound UnequipSound { get; set; }

		public audioMeleeWeaponConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
