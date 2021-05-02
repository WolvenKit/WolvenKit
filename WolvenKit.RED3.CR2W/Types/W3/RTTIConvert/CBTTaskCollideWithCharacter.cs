using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCollideWithCharacter : IBehTreeTask
	{
		[Ordinal(1)] [RED("isAvailable")] 		public CBool IsAvailable { get; set;}

		[Ordinal(2)] [RED("collideEndListenEventName")] 		public CName CollideEndListenEventName { get; set;}

		[Ordinal(3)] [RED("collideBehGrapEventName")] 		public CName CollideBehGrapEventName { get; set;}

		[Ordinal(4)] [RED("collidedConfirmedEvent")] 		public CName CollidedConfirmedEvent { get; set;}

		[Ordinal(5)] [RED("collidedDirBehGraphVar")] 		public CName CollidedDirBehGraphVar { get; set;}

		[Ordinal(6)] [RED("collidedPushBehGraphVar")] 		public CName CollidedPushBehGraphVar { get; set;}

		[Ordinal(7)] [RED("cooldownToRestartTotal")] 		public CFloat CooldownToRestartTotal { get; set;}

		[Ordinal(8)] [RED("cooldownToStartTotal")] 		public CFloat CooldownToStartTotal { get; set;}

		[Ordinal(9)] [RED("cooldownToRetryTotal")] 		public CFloat CooldownToRetryTotal { get; set;}

		[Ordinal(10)] [RED("cooldownToPlayCur")] 		public CFloat CooldownToPlayCur { get; set;}

		[Ordinal(11)] [RED("cooldownToRestartCur")] 		public CFloat CooldownToRestartCur { get; set;}

		[Ordinal(12)] [RED("cooldownToRetryCur")] 		public CFloat CooldownToRetryCur { get; set;}

		[Ordinal(13)] [RED("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		[Ordinal(14)] [RED("otherIsPlayer")] 		public CBool OtherIsPlayer { get; set;}

		[Ordinal(15)] [RED("otherIsHorse")] 		public CBool OtherIsHorse { get; set;}

		[Ordinal(16)] [RED("ignoreBumpOnOneGoingAway")] 		public CBool IgnoreBumpOnOneGoingAway { get; set;}

		[Ordinal(17)] [RED("ignoreBumpOnBothGoingAway")] 		public CBool IgnoreBumpOnBothGoingAway { get; set;}

		[Ordinal(18)] [RED("ignoreBumpOnBothStopped")] 		public CBool IgnoreBumpOnBothStopped { get; set;}

		[Ordinal(19)] [RED("ignoreMinCoefToGoAway")] 		public CFloat IgnoreMinCoefToGoAway { get; set;}

		[Ordinal(20)] [RED("ignoreMinSpeedSqr")] 		public CFloat IgnoreMinSpeedSqr { get; set;}

		public CBTTaskCollideWithCharacter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollideWithCharacter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}