using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateCombat : CExplorationStateAbstract
	{
		[RED("m_TimeToSlideNeededF")] 		public CFloat M_TimeToSlideNeededF { get; set;}

		[RED("m_TimeToSlideCurF")] 		public CFloat M_TimeToSlideCurF { get; set;}

		[RED("m_FallHasToWaitForCombatAction")] 		public CBool M_FallHasToWaitForCombatAction { get; set;}

		[RED("m_SlideHasToWaitForCombatAction")] 		public CBool M_SlideHasToWaitForCombatAction { get; set;}

		[RED("m_FallHorizontalImpulseCancelF")] 		public CFloat M_FallHorizontalImpulseCancelF { get; set;}

		[RED("m_FallHorizontalImpulseF")] 		public CFloat M_FallHorizontalImpulseF { get; set;}

		[RED("m_FallExtraVerticalImpulseF")] 		public CFloat M_FallExtraVerticalImpulseF { get; set;}

		[RED("m_TurnAdjustTimeSprintF")] 		public CFloat M_TurnAdjustTimeSprintF { get; set;}

		public CExplorationStateCombat(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateCombat(cr2w);

	}
}