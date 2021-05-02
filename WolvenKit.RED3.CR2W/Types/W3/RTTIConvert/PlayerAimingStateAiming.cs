using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class PlayerAimingStateAiming : CScriptableState
	{
		[Ordinal(1)] [RED("SLOWMO_SPEED")] 		public CFloat SLOWMO_SPEED { get; set;}

		[Ordinal(2)] [RED("AIM_ENTITY_DISPLACEMENT")] 		public CFloat AIM_ENTITY_DISPLACEMENT { get; set;}

		[Ordinal(3)] [RED("aimEntity")] 		public CHandle<CEntity> AimEntity { get; set;}

		[Ordinal(4)] [RED("radiusEntity")] 		public CHandle<CEntity> RadiusEntity { get; set;}

		[Ordinal(5)] [RED("stopAiming")] 		public CBool StopAiming { get; set;}

		[Ordinal(6)] [RED("startTime")] 		public CFloat StartTime { get; set;}

		[Ordinal(7)] [RED("traceManager")] 		public CHandle<CScriptBatchQueryAccessor> TraceManager { get; set;}

		[Ordinal(8)] [RED("cachedCamDirection")] 		public Vector CachedCamDirection { get; set;}

		[Ordinal(9)] [RED("cachedCamPosition")] 		public Vector CachedCamPosition { get; set;}

		[Ordinal(10)] [RED("cachedOwnerPosition")] 		public Vector CachedOwnerPosition { get; set;}

		[Ordinal(11)] [RED("sweepId")] 		public SScriptSweepId SweepId { get; set;}

		[Ordinal(12)] [RED("throwPosInitial")] 		public Vector ThrowPosInitial { get; set;}

		[Ordinal(13)] [RED("cachedTime")] 		public CFloat CachedTime { get; set;}

		[Ordinal(14)] [RED("speedMultCasuserId")] 		public CInt32 SpeedMultCasuserId { get; set;}

		public PlayerAimingStateAiming(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new PlayerAimingStateAiming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}