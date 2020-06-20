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

		public BTTaskDrainStatDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskDrainStatDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}