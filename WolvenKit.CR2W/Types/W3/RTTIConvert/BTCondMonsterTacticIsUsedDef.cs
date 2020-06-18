using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondMonsterTacticIsUsedDef : IBehTreeConditionalTaskDefinition
	{
		[RED("tactic")] 		public CEnum<EMonsterTactic> Tactic { get; set;}

		[RED("distanceToCheck")] 		public CFloat DistanceToCheck { get; set;}

		[RED("ignoreMyself")] 		public CBool IgnoreMyself { get; set;}

		public BTCondMonsterTacticIsUsedDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondMonsterTacticIsUsedDef(cr2w);

	}
}