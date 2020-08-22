using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potion_VitalityRegen : W3RegenEffect
	{
		[RED("combatRegen")] 		public SAbilityAttributeValue CombatRegen { get; set;}

		[RED("nonCombatRegen")] 		public SAbilityAttributeValue NonCombatRegen { get; set;}

		[RED("playerTarget")] 		public CHandle<CR4Player> PlayerTarget { get; set;}

		public W3Potion_VitalityRegen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Potion_VitalityRegen(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}