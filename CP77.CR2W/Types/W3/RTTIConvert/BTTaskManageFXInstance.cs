using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageFXInstance : IBehTreeTask
	{
		[Ordinal(1)] [RED("hasAbilityCondition")] 		public CName HasAbilityCondition { get; set;}

		[Ordinal(2)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(3)] [RED("fxTickets")] 		public CInt32 FxTickets { get; set;}

		[Ordinal(4)] [RED("distanceToAnotherFx")] 		public CFloat DistanceToAnotherFx { get; set;}

		[Ordinal(5)] [RED("fxInstanceCheckInterval")] 		public CFloat FxInstanceCheckInterval { get; set;}

		[Ordinal(6)] [RED("stopFxAfterDeath")] 		public CBool StopFxAfterDeath { get; set;}

		[Ordinal(7)] [RED("npcPos")] 		public Vector NpcPos { get; set;}

		[Ordinal(8)] [RED("fxInstances")] 		public CInt32 FxInstances { get; set;}

		public BTTaskManageFXInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageFXInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}