using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SResistanceValue : CVariable
	{
		[RED("points")] 		public SAbilityAttributeValue Points { get; set;}

		[RED("percents")] 		public SAbilityAttributeValue Percents { get; set;}

		[RED("type")] 		public CEnum<ECharacterDefenseStats> Type { get; set;}

		public SResistanceValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SResistanceValue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}