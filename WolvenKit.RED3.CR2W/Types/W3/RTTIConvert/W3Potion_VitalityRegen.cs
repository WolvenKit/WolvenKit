using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potion_VitalityRegen : W3RegenEffect
	{
		[Ordinal(1)] [RED("combatRegen")] 		public SAbilityAttributeValue CombatRegen { get; set;}

		[Ordinal(2)] [RED("nonCombatRegen")] 		public SAbilityAttributeValue NonCombatRegen { get; set;}

		[Ordinal(3)] [RED("playerTarget")] 		public CHandle<CR4Player> PlayerTarget { get; set;}

		public W3Potion_VitalityRegen(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}