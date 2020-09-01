using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlashStep : IBehTreeTask
	{
		[Ordinal(1)] [RED("vanish")] 		public CBool Vanish { get; set;}

		[Ordinal(2)] [RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[Ordinal(3)] [RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(4)] [RED("alreadyTeleported")] 		public CBool AlreadyTeleported { get; set;}

		[Ordinal(5)] [RED("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[Ordinal(6)] [RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(7)] [RED("appearFXName")] 		public CName AppearFXName { get; set;}

		[Ordinal(8)] [RED("emptyName")] 		public CName EmptyName { get; set;}

		[Ordinal(9)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(10)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(11)] [RED("distFromLastTelePos")] 		public CFloat DistFromLastTelePos { get; set;}

		[Ordinal(12)] [RED("cameraToPlayerDistance")] 		public CFloat CameraToPlayerDistance { get; set;}

		[Ordinal(13)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(14)] [RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(15)] [RED("nextTeleTime")] 		public CFloat NextTeleTime { get; set;}

		[Ordinal(16)] [RED("angle")] 		public CFloat Angle { get; set;}

		[Ordinal(17)] [RED("heading")] 		public Vector Heading { get; set;}

		[Ordinal(18)] [RED("lastTelePos")] 		public Vector LastTelePos { get; set;}

		[Ordinal(19)] [RED("randVec")] 		public Vector RandVec { get; set;}

		[Ordinal(20)] [RED("whereTo")] 		public Vector WhereTo { get; set;}

		[Ordinal(21)] [RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[Ordinal(22)] [RED("behEventName")] 		public CName BehEventName { get; set;}

		public CBTTaskFlashStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlashStep(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}