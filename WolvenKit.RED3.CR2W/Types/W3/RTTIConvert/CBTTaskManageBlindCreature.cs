using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageBlindCreature : IBehTreeTask
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("forgetTargetIfNPCSpeedLowerThan")] 		public CFloat ForgetTargetIfNPCSpeedLowerThan { get; set;}

		[Ordinal(3)] [RED("remberTargetIfCloserThan")] 		public CFloat RemberTargetIfCloserThan { get; set;}

		[Ordinal(4)] [RED("ignoreNoiseLowerThanWhenSprinting")] 		public CFloat IgnoreNoiseLowerThanWhenSprinting { get; set;}

		[Ordinal(5)] [RED("prioritizePlayerAsTarget")] 		public CBool PrioritizePlayerAsTarget { get; set;}

		[Ordinal(6)] [RED("teleportEntity")] 		public CBool TeleportEntity { get; set;}

		[Ordinal(7)] [RED("checkedForActors")] 		public CBool CheckedForActors { get; set;}

		[Ordinal(8)] [RED("echoPingShot")] 		public CBool EchoPingShot { get; set;}

		[Ordinal(9)] [RED("echoTimeStamp")] 		public CFloat EchoTimeStamp { get; set;}

		[Ordinal(10)] [RED("delayEchoDetectionFX")] 		public CFloat DelayEchoDetectionFX { get; set;}

		[Ordinal(11)] [RED("noiseSourceEntities", 2,0)] 		public CArray<SNoiseEntity> NoiseSourceEntities { get; set;}

		[Ordinal(12)] [RED("actors", 2,0)] 		public CArray<CHandle<CActor>> Actors { get; set;}

		[Ordinal(13)] [RED("noiseSourceEntity")] 		public SNoiseEntity NoiseSourceEntity { get; set;}

		[Ordinal(14)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(15)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(16)] [RED("PING_SPEED")] 		public CFloat PING_SPEED { get; set;}

		[Ordinal(17)] [RED("PING_NOISE_LEVEL")] 		public CFloat PING_NOISE_LEVEL { get; set;}

		[Ordinal(18)] [RED("BOMB_NOISE_LEVEL")] 		public CFloat BOMB_NOISE_LEVEL { get; set;}

		[Ordinal(19)] [RED("SIGN_NOISE_LEVEL")] 		public CFloat SIGN_NOISE_LEVEL { get; set;}

		[Ordinal(20)] [RED("BATTLECRY_NOISE_LEVEL")] 		public CFloat BATTLECRY_NOISE_LEVEL { get; set;}

		[Ordinal(21)] [RED("ATTACK_NOISE_LEVEL")] 		public CFloat ATTACK_NOISE_LEVEL { get; set;}

		[Ordinal(22)] [RED("MOVE_NOISE_LEVEL")] 		public CFloat MOVE_NOISE_LEVEL { get; set;}

		[Ordinal(23)] [RED("Z_TOLERANCE")] 		public CFloat Z_TOLERANCE { get; set;}

		[Ordinal(24)] [RED("NAVIGATION_SEARCH_RADIUS")] 		public CFloat NAVIGATION_SEARCH_RADIUS { get; set;}

		[Ordinal(25)] [RED("NAVIGATION_SEARCH_TIMEOUT")] 		public CFloat NAVIGATION_SEARCH_TIMEOUT { get; set;}

		public CBTTaskManageBlindCreature(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}