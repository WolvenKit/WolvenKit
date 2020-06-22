using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCastQuen : CBTTaskCastSign
	{
		[RED("completeAfterHit")] 		public CBool CompleteAfterHit { get; set;}

		[RED("alternateFireMode")] 		public CBool AlternateFireMode { get; set;}

		[RED("processQuenOnCounterActivation")] 		public CBool ProcessQuenOnCounterActivation { get; set;}

		[RED("hitEventReceived")] 		public CBool HitEventReceived { get; set;}

		[RED("hitEntity")] 		public CHandle<CEntity> HitEntity { get; set;}

		[RED("hitEntityTemplate")] 		public CHandle<CEntityTemplate> HitEntityTemplate { get; set;}

		[RED("ownerBoneIndex")] 		public CInt32 OwnerBoneIndex { get; set;}

		[RED("shieldActive")] 		public CBool ShieldActive { get; set;}

		[RED("humanCombatDataStorage")] 		public CHandle<CHumanAICombatStorage> HumanCombatDataStorage { get; set;}

		[RED("playEffectTimeStamp")] 		public CFloat PlayEffectTimeStamp { get; set;}

		public CBTTaskCastQuen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCastQuen(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}