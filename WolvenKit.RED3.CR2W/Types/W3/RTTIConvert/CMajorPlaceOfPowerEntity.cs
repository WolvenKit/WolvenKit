using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMajorPlaceOfPowerEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(2)] [RED("buffType")] 		public CEnum<EShrineBuffs> BuffType { get; set;}

		[Ordinal(3)] [RED("buffUniqueName")] 		public CString BuffUniqueName { get; set;}

		[Ordinal(4)] [RED("fxOnIdle")] 		public CName FxOnIdle { get; set;}

		[Ordinal(5)] [RED("fxOnChannel")] 		public CName FxOnChannel { get; set;}

		[Ordinal(6)] [RED("fxOnSuccess")] 		public CName FxOnSuccess { get; set;}

		[Ordinal(7)] [RED("channelingTime")] 		public CFloat ChannelingTime { get; set;}

		[Ordinal(8)] [RED("buffDuration")] 		public CFloat BuffDuration { get; set;}

		[Ordinal(9)] [RED("buffCooldown")] 		public GameTime BuffCooldown { get; set;}

		[Ordinal(10)] [RED("skillPointGranted")] 		public CBool SkillPointGranted { get; set;}

		[Ordinal(11)] [RED("isRecharging")] 		public CBool IsRecharging { get; set;}

		[Ordinal(12)] [RED("lastUsed")] 		public GameTime LastUsed { get; set;}

		[Ordinal(13)] [RED("isPlaceOfPowerInIdle")] 		public CBool IsPlaceOfPowerInIdle { get; set;}

		[Ordinal(14)] [RED("voicesetTimestamp")] 		public GameTime VoicesetTimestamp { get; set;}

		[Ordinal(15)] [RED("initialVoicesetPlayed")] 		public CBool InitialVoicesetPlayed { get; set;}

		public CMajorPlaceOfPowerEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}