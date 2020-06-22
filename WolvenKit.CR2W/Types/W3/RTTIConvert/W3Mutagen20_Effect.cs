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
		[RED("burningPoints")] 		public SAbilityAttributeValue BurningPoints { get; set;}

		[RED("burningPercents")] 		public SAbilityAttributeValue BurningPercents { get; set;}

		[RED("poisonPoints")] 		public SAbilityAttributeValue PoisonPoints { get; set;}

		[RED("poisonPercents")] 		public SAbilityAttributeValue PoisonPercents { get; set;}

		[RED("bleedingPoints")] 		public SAbilityAttributeValue BleedingPoints { get; set;}

		[RED("bleedingPercents")] 		public SAbilityAttributeValue BleedingPercents { get; set;}

		[RED("burningResistanceCounter")] 		public CFloat BurningResistanceCounter { get; set;}

		[RED("poisonResistanceCounter")] 		public CFloat PoisonResistanceCounter { get; set;}

		[RED("bleedingResistanceCounter")] 		public CFloat BleedingResistanceCounter { get; set;}

		[RED("player")] 		public CHandle<CR4Player> Player { get; set;}

		public W3Mutagen20_Effect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Mutagen20_Effect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}