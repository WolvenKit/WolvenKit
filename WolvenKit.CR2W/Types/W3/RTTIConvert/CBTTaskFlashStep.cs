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
		[RED("vanish")] 		public CBool Vanish { get; set;}

		[RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[RED("alreadyTeleported")] 		public CBool AlreadyTeleported { get; set;}

		[RED("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[RED("appearFXName")] 		public CName AppearFXName { get; set;}

		[RED("emptyName")] 		public CName EmptyName { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("distFromLastTelePos")] 		public CFloat DistFromLastTelePos { get; set;}

		[RED("cameraToPlayerDistance")] 		public CFloat CameraToPlayerDistance { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[RED("nextTeleTime")] 		public CFloat NextTeleTime { get; set;}

		[RED("angle")] 		public CFloat Angle { get; set;}

		[RED("heading")] 		public Vector Heading { get; set;}

		[RED("lastTelePos")] 		public Vector LastTelePos { get; set;}

		[RED("randVec")] 		public Vector RandVec { get; set;}

		[RED("whereTo")] 		public Vector WhereTo { get; set;}

		[RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[RED("behEventName")] 		public CName BehEventName { get; set;}

		public CBTTaskFlashStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlashStep(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}