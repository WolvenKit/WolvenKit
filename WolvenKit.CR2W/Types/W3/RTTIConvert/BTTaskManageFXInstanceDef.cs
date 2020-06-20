using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageFXInstanceDef : IBehTreeTaskDefinition
	{
		[RED("hasAbilityCondition")] 		public CName HasAbilityCondition { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("fxTickets")] 		public CInt32 FxTickets { get; set;}

		[RED("distanceToAnotherFx")] 		public CFloat DistanceToAnotherFx { get; set;}

		[RED("fxInstanceCheckInterval")] 		public CFloat FxInstanceCheckInterval { get; set;}

		[RED("stopFxAfterDeath")] 		public CBool StopFxAfterDeath { get; set;}

		public BTTaskManageFXInstanceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageFXInstanceDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}