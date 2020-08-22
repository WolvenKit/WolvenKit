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
		[RED("ARM_INTERACTION_COMPONENT_NAME")] 		public CString ARM_INTERACTION_COMPONENT_NAME { get; set;}

		[RED("DISARM_INTERACTION_COMPONENT_NAME")] 		public CString DISARM_INTERACTION_COMPONENT_NAME { get; set;}

		[RED("m_IsActive")] 		public CBool M_IsActive { get; set;}

		[RED("m_Targets", 2,0)] 		public CArray<CHandle<CNode>> M_Targets { get; set;}

		[RED("m_isArmed")] 		public CBool M_isArmed { get; set;}

		[RED("m_wasSprung")] 		public CBool M_wasSprung { get; set;}

		[RED("m_isPlayingAnimation")] 		public CBool M_isPlayingAnimation { get; set;}

		[RED("activeByDefault")] 		public CBool ActiveByDefault { get; set;}

		[RED("factOnArm")] 		public SFactParameters FactOnArm { get; set;}

		[RED("factOnDisarm")] 		public SFactParameters FactOnDisarm { get; set;}

		[RED("factOnActivation")] 		public SFactParameters FactOnActivation { get; set;}

		[RED("factOnDeactivation")] 		public SFactParameters FactOnDeactivation { get; set;}

		[RED("deactivateAfterTime")] 		public CFloat DeactivateAfterTime { get; set;}

		[RED("appearanceActivated")] 		public CString AppearanceActivated { get; set;}

		[RED("appearanceDeactived")] 		public CString AppearanceDeactived { get; set;}

		[RED("appearanceArmed")] 		public CString AppearanceArmed { get; set;}

		[RED("appearanceDisarmed")] 		public CString AppearanceDisarmed { get; set;}

		[RED("canBeArmed")] 		public CBool CanBeArmed { get; set;}

		[RED("interactibleAfterSprung")] 		public CBool InteractibleAfterSprung { get; set;}

		[RED("willActivateWhenHit")] 		public CBool WillActivateWhenHit { get; set;}

		[RED("soundOnArm")] 		public CName SoundOnArm { get; set;}

		[RED("soundOnDisarm")] 		public CName SoundOnDisarm { get; set;}

		public W3Trap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Trap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}