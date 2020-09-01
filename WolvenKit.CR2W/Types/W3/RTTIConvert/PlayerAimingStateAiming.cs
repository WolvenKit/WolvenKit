using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class PlayerAimingStateAiming : CScriptableState
	{
		[Ordinal(0)] [RED("SLOWMO_SPEED")] 		public CFloat SLOWMO_SPEED { get; set;}

		[Ordinal(0)] [RED("AIM_ENTITY_DISPLACEMENT")] 		public CFloat AIM_ENTITY_DISPLACEMENT { get; set;}

		[Ordinal(0)] [RED("aimEntity")] 		public CHandle<CEntity> AimEntity { get; set;}

		[Ordinal(0)] [RED("radiusEntity")] 		public CHandle<CEntity> RadiusEntity { get; set;}

		[Ordinal(0)] [RED("stopAiming")] 		public CBool StopAiming { get; set;}

		[Ordinal(0)] [RED("startTime")] 		public CFloat StartTime { get; set;}

		[Ordinal(0)] [RED("traceManager")] 		public CHandle<CScriptBatchQueryAccessor> TraceManager { get; set;}

		[Ordinal(0)] [RED("cachedCamDirection")] 		public Vector CachedCamDirection { get; set;}

		[Ordinal(0)] [RED("cachedCamPosition")] 		public Vector CachedCamPosition { get; set;}

		[Ordinal(0)] [RED("cachedOwnerPosition")] 		public Vector CachedOwnerPosition { get; set;}

		[Ordinal(0)] [RED("sweepId")] 		public SScriptSweepId SweepId { get; set;}

		[Ordinal(0)] [RED("throwPosInitial")] 		public Vector ThrowPosInitial { get; set;}

		[Ordinal(0)] [RED("cachedTime")] 		public CFloat CachedTime { get; set;}

		[Ordinal(0)] [RED("speedMultCasuserId")] 		public CInt32 SpeedMultCasuserId { get; set;}

		public PlayerAimingStateAiming(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new PlayerAimingStateAiming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}