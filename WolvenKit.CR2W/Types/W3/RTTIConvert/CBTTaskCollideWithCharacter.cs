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
		[RED("isAvailable")] 		public CBool IsAvailable { get; set;}

		[RED("collideEndListenEventName")] 		public CName CollideEndListenEventName { get; set;}

		[RED("collideBehGrapEventName")] 		public CName CollideBehGrapEventName { get; set;}

		[RED("collidedConfirmedEvent")] 		public CName CollidedConfirmedEvent { get; set;}

		[RED("collidedDirBehGraphVar")] 		public CName CollidedDirBehGraphVar { get; set;}

		[RED("collidedPushBehGraphVar")] 		public CName CollidedPushBehGraphVar { get; set;}

		[RED("cooldownToRestartTotal")] 		public CFloat CooldownToRestartTotal { get; set;}

		[RED("cooldownToStartTotal")] 		public CFloat CooldownToStartTotal { get; set;}

		[RED("cooldownToRetryTotal")] 		public CFloat CooldownToRetryTotal { get; set;}

		[RED("cooldownToPlayCur")] 		public CFloat CooldownToPlayCur { get; set;}

		[RED("cooldownToRestartCur")] 		public CFloat CooldownToRestartCur { get; set;}

		[RED("cooldownToRetryCur")] 		public CFloat CooldownToRetryCur { get; set;}

		[RED("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		[RED("otherIsPlayer")] 		public CBool OtherIsPlayer { get; set;}

		[RED("otherIsHorse")] 		public CBool OtherIsHorse { get; set;}

		[RED("ignoreBumpOnOneGoingAway")] 		public CBool IgnoreBumpOnOneGoingAway { get; set;}

		[RED("ignoreBumpOnBothGoingAway")] 		public CBool IgnoreBumpOnBothGoingAway { get; set;}

		[RED("ignoreBumpOnBothStopped")] 		public CBool IgnoreBumpOnBothStopped { get; set;}

		[RED("ignoreMinCoefToGoAway")] 		public CFloat IgnoreMinCoefToGoAway { get; set;}

		[RED("ignoreMinSpeedSqr")] 		public CFloat IgnoreMinSpeedSqr { get; set;}

		public CBTTaskCollideWithCharacter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollideWithCharacter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}