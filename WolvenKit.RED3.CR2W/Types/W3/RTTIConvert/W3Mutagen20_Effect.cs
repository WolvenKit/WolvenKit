using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Mutagen20_Effect : W3Mutagen_Effect
	{
		[Ordinal(1)] [RED("burningPoints")] 		public SAbilityAttributeValue BurningPoints { get; set;}

		[Ordinal(2)] [RED("burningPercents")] 		public SAbilityAttributeValue BurningPercents { get; set;}

		[Ordinal(3)] [RED("poisonPoints")] 		public SAbilityAttributeValue PoisonPoints { get; set;}

		[Ordinal(4)] [RED("poisonPercents")] 		public SAbilityAttributeValue PoisonPercents { get; set;}

		[Ordinal(5)] [RED("bleedingPoints")] 		public SAbilityAttributeValue BleedingPoints { get; set;}

		[Ordinal(6)] [RED("bleedingPercents")] 		public SAbilityAttributeValue BleedingPercents { get; set;}

		[Ordinal(7)] [RED("burningResistanceCounter")] 		public CFloat BurningResistanceCounter { get; set;}

		[Ordinal(8)] [RED("poisonResistanceCounter")] 		public CFloat PoisonResistanceCounter { get; set;}

		[Ordinal(9)] [RED("bleedingResistanceCounter")] 		public CFloat BleedingResistanceCounter { get; set;}

		[Ordinal(10)] [RED("player")] 		public CHandle<CR4Player> Player { get; set;}

		public W3Mutagen20_Effect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Mutagen20_Effect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}