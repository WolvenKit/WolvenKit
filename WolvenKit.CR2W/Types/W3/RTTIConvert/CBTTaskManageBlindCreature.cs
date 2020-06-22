using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageBlindCreature : IBehTreeTask
	{
		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("forgetTargetIfNPCSpeedLowerThan")] 		public CFloat ForgetTargetIfNPCSpeedLowerThan { get; set;}

		[RED("remberTargetIfCloserThan")] 		public CFloat RemberTargetIfCloserThan { get; set;}

		[RED("ignoreNoiseLowerThanWhenSprinting")] 		public CFloat IgnoreNoiseLowerThanWhenSprinting { get; set;}

		[RED("prioritizePlayerAsTarget")] 		public CBool PrioritizePlayerAsTarget { get; set;}

		[RED("teleportEntity")] 		public CBool TeleportEntity { get; set;}

		[RED("checkedForActors")] 		public CBool CheckedForActors { get; set;}

		[RED("echoPingShot")] 		public CBool EchoPingShot { get; set;}

		[RED("echoTimeStamp")] 		public CFloat EchoTimeStamp { get; set;}

		[RED("delayEchoDetectionFX")] 		public CFloat DelayEchoDetectionFX { get; set;}

		[RED("noiseSourceEntities", 2,0)] 		public CArray<SNoiseEntity> NoiseSourceEntities { get; set;}

		[RED("actors", 2,0)] 		public CArray<CHandle<CActor>> Actors { get; set;}

		[RED("noiseSourceEntity")] 		public SNoiseEntity NoiseSourceEntity { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("PING_SPEED")] 		public CFloat PING_SPEED { get; set;}

		[RED("PING_NOISE_LEVEL")] 		public CFloat PING_NOISE_LEVEL { get; set;}

		[RED("BOMB_NOISE_LEVEL")] 		public CFloat BOMB_NOISE_LEVEL { get; set;}

		[RED("SIGN_NOISE_LEVEL")] 		public CFloat SIGN_NOISE_LEVEL { get; set;}

		[RED("BATTLECRY_NOISE_LEVEL")] 		public CFloat BATTLECRY_NOISE_LEVEL { get; set;}

		[RED("ATTACK_NOISE_LEVEL")] 		public CFloat ATTACK_NOISE_LEVEL { get; set;}

		[RED("MOVE_NOISE_LEVEL")] 		public CFloat MOVE_NOISE_LEVEL { get; set;}

		[RED("Z_TOLERANCE")] 		public CFloat Z_TOLERANCE { get; set;}

		[RED("NAVIGATION_SEARCH_RADIUS")] 		public CFloat NAVIGATION_SEARCH_RADIUS { get; set;}

		[RED("NAVIGATION_SEARCH_TIMEOUT")] 		public CFloat NAVIGATION_SEARCH_TIMEOUT { get; set;}

		public CBTTaskManageBlindCreature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageBlindCreature(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}