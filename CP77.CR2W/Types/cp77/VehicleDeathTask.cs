using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDeathTask : AIDeathReactionsTask
	{
		[Ordinal(3)] [RED("vehNPCDeathData")] public CHandle<AnimFeature_VehicleNPCDeathData> VehNPCDeathData { get; set; }
		[Ordinal(4)] [RED("previousState")] public CEnum<gamedataNPCHighLevelState> PreviousState { get; set; }
		[Ordinal(5)] [RED("timeToRagdoll")] public CFloat TimeToRagdoll { get; set; }
		[Ordinal(6)] [RED("hasRagdolled")] public CBool HasRagdolled { get; set; }
		[Ordinal(7)] [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(8)] [RED("readyToUnmount")] public CBool ReadyToUnmount { get; set; }

		public VehicleDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
