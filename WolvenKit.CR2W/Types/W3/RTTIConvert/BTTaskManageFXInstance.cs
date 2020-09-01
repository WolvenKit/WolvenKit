using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageFXInstance : IBehTreeTask
	{
		[Ordinal(0)] [RED("hasAbilityCondition")] 		public CName HasAbilityCondition { get; set;}

		[Ordinal(0)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(0)] [RED("fxTickets")] 		public CInt32 FxTickets { get; set;}

		[Ordinal(0)] [RED("distanceToAnotherFx")] 		public CFloat DistanceToAnotherFx { get; set;}

		[Ordinal(0)] [RED("fxInstanceCheckInterval")] 		public CFloat FxInstanceCheckInterval { get; set;}

		[Ordinal(0)] [RED("stopFxAfterDeath")] 		public CBool StopFxAfterDeath { get; set;}

		[Ordinal(0)] [RED("npcPos")] 		public Vector NpcPos { get; set;}

		[Ordinal(0)] [RED("fxInstances")] 		public CInt32 FxInstances { get; set;}

		public BTTaskManageFXInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageFXInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}