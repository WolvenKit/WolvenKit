using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCollideWithCharacter : IBehTreeTask
	{
		[Ordinal(0)] [RED("("isAvailable")] 		public CBool IsAvailable { get; set;}

		[Ordinal(0)] [RED("("collideEndListenEventName")] 		public CName CollideEndListenEventName { get; set;}

		[Ordinal(0)] [RED("("collideBehGrapEventName")] 		public CName CollideBehGrapEventName { get; set;}

		[Ordinal(0)] [RED("("collidedConfirmedEvent")] 		public CName CollidedConfirmedEvent { get; set;}

		[Ordinal(0)] [RED("("collidedDirBehGraphVar")] 		public CName CollidedDirBehGraphVar { get; set;}

		[Ordinal(0)] [RED("("collidedPushBehGraphVar")] 		public CName CollidedPushBehGraphVar { get; set;}

		[Ordinal(0)] [RED("("cooldownToRestartTotal")] 		public CFloat CooldownToRestartTotal { get; set;}

		[Ordinal(0)] [RED("("cooldownToStartTotal")] 		public CFloat CooldownToStartTotal { get; set;}

		[Ordinal(0)] [RED("("cooldownToRetryTotal")] 		public CFloat CooldownToRetryTotal { get; set;}

		[Ordinal(0)] [RED("("cooldownToPlayCur")] 		public CFloat CooldownToPlayCur { get; set;}

		[Ordinal(0)] [RED("("cooldownToRestartCur")] 		public CFloat CooldownToRestartCur { get; set;}

		[Ordinal(0)] [RED("("cooldownToRetryCur")] 		public CFloat CooldownToRetryCur { get; set;}

		[Ordinal(0)] [RED("("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		[Ordinal(0)] [RED("("otherIsPlayer")] 		public CBool OtherIsPlayer { get; set;}

		[Ordinal(0)] [RED("("otherIsHorse")] 		public CBool OtherIsHorse { get; set;}

		[Ordinal(0)] [RED("("ignoreBumpOnOneGoingAway")] 		public CBool IgnoreBumpOnOneGoingAway { get; set;}

		[Ordinal(0)] [RED("("ignoreBumpOnBothGoingAway")] 		public CBool IgnoreBumpOnBothGoingAway { get; set;}

		[Ordinal(0)] [RED("("ignoreBumpOnBothStopped")] 		public CBool IgnoreBumpOnBothStopped { get; set;}

		[Ordinal(0)] [RED("("ignoreMinCoefToGoAway")] 		public CFloat IgnoreMinCoefToGoAway { get; set;}

		[Ordinal(0)] [RED("("ignoreMinSpeedSqr")] 		public CFloat IgnoreMinSpeedSqr { get; set;}

		public CBTTaskCollideWithCharacter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollideWithCharacter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}