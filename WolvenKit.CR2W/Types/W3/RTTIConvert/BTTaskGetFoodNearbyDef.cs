using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskGetFoodNearbyDef : IBehTreeTaskDefinition
	{
		[RED("corpse")] 		public CBehTreeValBool Corpse { get; set;}

		[RED("meat")] 		public CBehTreeValBool Meat { get; set;}

		[RED("vegetable")] 		public CBehTreeValBool Vegetable { get; set;}

		[RED("water")] 		public CBehTreeValBool Water { get; set;}

		[RED("monster")] 		public CBehTreeValBool Monster { get; set;}

		[RED("completeIfTargetChange")] 		public CBool CompleteIfTargetChange { get; set;}

		public BTTaskGetFoodNearbyDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskGetFoodNearbyDef(cr2w);

	}
}