using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskDrainStatDef : IBehTreeTaskDefinition
	{
		[RED("stat")] 		public CEnum<EBaseCharacterStats> Stat { get; set;}

		[RED("val")] 		public CFloat Val { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		public BTTaskDrainStatDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskDrainStatDef(cr2w);

	}
}