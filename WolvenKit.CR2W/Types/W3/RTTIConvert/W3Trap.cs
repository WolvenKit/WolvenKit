using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Trap : W3MonsterClue
	{
		[Ordinal(1)] [RED("("ARM_INTERACTION_COMPONENT_NAME")] 		public CString ARM_INTERACTION_COMPONENT_NAME { get; set;}

		[Ordinal(2)] [RED("("DISARM_INTERACTION_COMPONENT_NAME")] 		public CString DISARM_INTERACTION_COMPONENT_NAME { get; set;}

		[Ordinal(3)] [RED("("m_IsActive")] 		public CBool M_IsActive { get; set;}

		[Ordinal(4)] [RED("("m_Targets", 2,0)] 		public CArray<CHandle<CNode>> M_Targets { get; set;}

		[Ordinal(5)] [RED("("m_isArmed")] 		public CBool M_isArmed { get; set;}

		[Ordinal(6)] [RED("("m_wasSprung")] 		public CBool M_wasSprung { get; set;}

		[Ordinal(7)] [RED("("m_isPlayingAnimation")] 		public CBool M_isPlayingAnimation { get; set;}

		[Ordinal(8)] [RED("("activeByDefault")] 		public CBool ActiveByDefault { get; set;}

		[Ordinal(9)] [RED("("factOnArm")] 		public SFactParameters FactOnArm { get; set;}

		[Ordinal(10)] [RED("("factOnDisarm")] 		public SFactParameters FactOnDisarm { get; set;}

		[Ordinal(11)] [RED("("factOnActivation")] 		public SFactParameters FactOnActivation { get; set;}

		[Ordinal(12)] [RED("("factOnDeactivation")] 		public SFactParameters FactOnDeactivation { get; set;}

		[Ordinal(13)] [RED("("deactivateAfterTime")] 		public CFloat DeactivateAfterTime { get; set;}

		[Ordinal(14)] [RED("("appearanceActivated")] 		public CString AppearanceActivated { get; set;}

		[Ordinal(15)] [RED("("appearanceDeactived")] 		public CString AppearanceDeactived { get; set;}

		[Ordinal(16)] [RED("("appearanceArmed")] 		public CString AppearanceArmed { get; set;}

		[Ordinal(17)] [RED("("appearanceDisarmed")] 		public CString AppearanceDisarmed { get; set;}

		[Ordinal(18)] [RED("("canBeArmed")] 		public CBool CanBeArmed { get; set;}

		[Ordinal(19)] [RED("("interactibleAfterSprung")] 		public CBool InteractibleAfterSprung { get; set;}

		[Ordinal(20)] [RED("("willActivateWhenHit")] 		public CBool WillActivateWhenHit { get; set;}

		[Ordinal(21)] [RED("("soundOnArm")] 		public CName SoundOnArm { get; set;}

		[Ordinal(22)] [RED("("soundOnDisarm")] 		public CName SoundOnDisarm { get; set;}

		public W3Trap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Trap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}