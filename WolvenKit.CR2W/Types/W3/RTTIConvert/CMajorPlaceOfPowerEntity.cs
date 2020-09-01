using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMajorPlaceOfPowerEntity : CInteractiveEntity
	{
		[Ordinal(0)] [RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(0)] [RED("buffType")] 		public CEnum<EShrineBuffs> BuffType { get; set;}

		[Ordinal(0)] [RED("buffUniqueName")] 		public CString BuffUniqueName { get; set;}

		[Ordinal(0)] [RED("fxOnIdle")] 		public CName FxOnIdle { get; set;}

		[Ordinal(0)] [RED("fxOnChannel")] 		public CName FxOnChannel { get; set;}

		[Ordinal(0)] [RED("fxOnSuccess")] 		public CName FxOnSuccess { get; set;}

		[Ordinal(0)] [RED("channelingTime")] 		public CFloat ChannelingTime { get; set;}

		[Ordinal(0)] [RED("buffDuration")] 		public CFloat BuffDuration { get; set;}

		[Ordinal(0)] [RED("buffCooldown")] 		public GameTime BuffCooldown { get; set;}

		[Ordinal(0)] [RED("skillPointGranted")] 		public CBool SkillPointGranted { get; set;}

		[Ordinal(0)] [RED("isRecharging")] 		public CBool IsRecharging { get; set;}

		[Ordinal(0)] [RED("lastUsed")] 		public GameTime LastUsed { get; set;}

		[Ordinal(0)] [RED("isPlaceOfPowerInIdle")] 		public CBool IsPlaceOfPowerInIdle { get; set;}

		[Ordinal(0)] [RED("voicesetTimestamp")] 		public GameTime VoicesetTimestamp { get; set;}

		[Ordinal(0)] [RED("initialVoicesetPlayed")] 		public CBool InitialVoicesetPlayed { get; set;}

		public CMajorPlaceOfPowerEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMajorPlaceOfPowerEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}