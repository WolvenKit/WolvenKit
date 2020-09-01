using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Mutagen20_Effect : W3Mutagen_Effect
	{
		[Ordinal(0)] [RED("("burningPoints")] 		public SAbilityAttributeValue BurningPoints { get; set;}

		[Ordinal(0)] [RED("("burningPercents")] 		public SAbilityAttributeValue BurningPercents { get; set;}

		[Ordinal(0)] [RED("("poisonPoints")] 		public SAbilityAttributeValue PoisonPoints { get; set;}

		[Ordinal(0)] [RED("("poisonPercents")] 		public SAbilityAttributeValue PoisonPercents { get; set;}

		[Ordinal(0)] [RED("("bleedingPoints")] 		public SAbilityAttributeValue BleedingPoints { get; set;}

		[Ordinal(0)] [RED("("bleedingPercents")] 		public SAbilityAttributeValue BleedingPercents { get; set;}

		[Ordinal(0)] [RED("("burningResistanceCounter")] 		public CFloat BurningResistanceCounter { get; set;}

		[Ordinal(0)] [RED("("poisonResistanceCounter")] 		public CFloat PoisonResistanceCounter { get; set;}

		[Ordinal(0)] [RED("("bleedingResistanceCounter")] 		public CFloat BleedingResistanceCounter { get; set;}

		[Ordinal(0)] [RED("("player")] 		public CHandle<CR4Player> Player { get; set;}

		public W3Mutagen20_Effect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Mutagen20_Effect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}