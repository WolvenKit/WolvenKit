using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlashStep : IBehTreeTask
	{
		[Ordinal(0)] [RED("("vanish")] 		public CBool Vanish { get; set;}

		[Ordinal(0)] [RED("("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[Ordinal(0)] [RED("("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(0)] [RED("("alreadyTeleported")] 		public CBool AlreadyTeleported { get; set;}

		[Ordinal(0)] [RED("("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[Ordinal(0)] [RED("("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(0)] [RED("("appearFXName")] 		public CName AppearFXName { get; set;}

		[Ordinal(0)] [RED("("emptyName")] 		public CName EmptyName { get; set;}

		[Ordinal(0)] [RED("("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(0)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("("distFromLastTelePos")] 		public CFloat DistFromLastTelePos { get; set;}

		[Ordinal(0)] [RED("("cameraToPlayerDistance")] 		public CFloat CameraToPlayerDistance { get; set;}

		[Ordinal(0)] [RED("("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(0)] [RED("("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(0)] [RED("("nextTeleTime")] 		public CFloat NextTeleTime { get; set;}

		[Ordinal(0)] [RED("("angle")] 		public CFloat Angle { get; set;}

		[Ordinal(0)] [RED("("heading")] 		public Vector Heading { get; set;}

		[Ordinal(0)] [RED("("lastTelePos")] 		public Vector LastTelePos { get; set;}

		[Ordinal(0)] [RED("("randVec")] 		public Vector RandVec { get; set;}

		[Ordinal(0)] [RED("("whereTo")] 		public Vector WhereTo { get; set;}

		[Ordinal(0)] [RED("("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[Ordinal(0)] [RED("("behEventName")] 		public CName BehEventName { get; set;}

		public CBTTaskFlashStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlashStep(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}