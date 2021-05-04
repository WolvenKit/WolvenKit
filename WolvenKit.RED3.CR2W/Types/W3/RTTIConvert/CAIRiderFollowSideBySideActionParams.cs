using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIRiderFollowSideBySideActionParams : CAIRiderFollowActionParams
	{
		[Ordinal(1)] [RED("useCustomSteering")] 		public CBool UseCustomSteering { get; set;}

		[Ordinal(2)] [RED("customSteeringGraph")] 		public CHandle<CMoveSteeringBehavior> CustomSteeringGraph { get; set;}

		[Ordinal(3)] [RED("horseCustomSteeringGraph")] 		public CHandle<CMoveSteeringBehavior> HorseCustomSteeringGraph { get; set;}

		public CAIRiderFollowSideBySideActionParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}