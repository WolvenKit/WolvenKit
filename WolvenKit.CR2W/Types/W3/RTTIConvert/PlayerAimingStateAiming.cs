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
		[RED("SLOWMO_SPEED")] 		public CFloat SLOWMO_SPEED { get; set;}

		[RED("AIM_ENTITY_DISPLACEMENT")] 		public CFloat AIM_ENTITY_DISPLACEMENT { get; set;}

		[RED("aimEntity")] 		public CHandle<CEntity> AimEntity { get; set;}

		[RED("radiusEntity")] 		public CHandle<CEntity> RadiusEntity { get; set;}

		[RED("stopAiming")] 		public CBool StopAiming { get; set;}

		[RED("startTime")] 		public CFloat StartTime { get; set;}

		[RED("traceManager")] 		public CHandle<CScriptBatchQueryAccessor> TraceManager { get; set;}

		[RED("cachedCamDirection")] 		public Vector CachedCamDirection { get; set;}

		[RED("cachedCamPosition")] 		public Vector CachedCamPosition { get; set;}

		[RED("cachedOwnerPosition")] 		public Vector CachedOwnerPosition { get; set;}

		[RED("sweepId")] 		public SScriptSweepId SweepId { get; set;}

		[RED("throwPosInitial")] 		public Vector ThrowPosInitial { get; set;}

		[RED("cachedTime")] 		public CFloat CachedTime { get; set;}

		[RED("speedMultCasuserId")] 		public CInt32 SpeedMultCasuserId { get; set;}

		public PlayerAimingStateAiming(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new PlayerAimingStateAiming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}