using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCastQuen : CBTTaskCastSign
	{
		[Ordinal(1)] [RED("completeAfterHit")] 		public CBool CompleteAfterHit { get; set;}

		[Ordinal(2)] [RED("alternateFireMode")] 		public CBool AlternateFireMode { get; set;}

		[Ordinal(3)] [RED("processQuenOnCounterActivation")] 		public CBool ProcessQuenOnCounterActivation { get; set;}

		[Ordinal(4)] [RED("hitEventReceived")] 		public CBool HitEventReceived { get; set;}

		[Ordinal(5)] [RED("hitEntity")] 		public CHandle<CEntity> HitEntity { get; set;}

		[Ordinal(6)] [RED("hitEntityTemplate")] 		public CHandle<CEntityTemplate> HitEntityTemplate { get; set;}

		[Ordinal(7)] [RED("ownerBoneIndex")] 		public CInt32 OwnerBoneIndex { get; set;}

		[Ordinal(8)] [RED("shieldActive")] 		public CBool ShieldActive { get; set;}

		[Ordinal(9)] [RED("humanCombatDataStorage")] 		public CHandle<CHumanAICombatStorage> HumanCombatDataStorage { get; set;}

		[Ordinal(10)] [RED("playEffectTimeStamp")] 		public CFloat PlayEffectTimeStamp { get; set;}

		public CBTTaskCastQuen(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}