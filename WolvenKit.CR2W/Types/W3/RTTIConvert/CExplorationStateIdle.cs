using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateIdle : CExplorationStateAbstract
	{
		[RED("m_SubStateLasE")] 		public CEnum<EPlayerIdleSubstate> M_SubStateLasE { get; set;}

		[RED("m_SubStateE")] 		public CEnum<EPlayerIdleSubstate> M_SubStateE { get; set;}

		[RED("m_SpeedMaxConsideredSprintF")] 		public CFloat M_SpeedMaxConsideredSprintF { get; set;}

		[RED("m_SpeedMaxConsideredRunF")] 		public CFloat M_SpeedMaxConsideredRunF { get; set;}

		[RED("m_SpeedMaxConsideredWalkF")] 		public CFloat M_SpeedMaxConsideredWalkF { get; set;}

		[RED("m_FallSpeedCoefF")] 		public CFloat M_FallSpeedCoefF { get; set;}

		[RED("m_FallExtraVerticalImpulseF")] 		public CFloat M_FallExtraVerticalImpulseF { get; set;}

		[RED("m_FallHorizontalImpulseF")] 		public CFloat M_FallHorizontalImpulseF { get; set;}

		[RED("m_FallHorizontalImpulseCancelF")] 		public CFloat M_FallHorizontalImpulseCancelF { get; set;}

		[RED("m_TimeToSlideNeededF")] 		public CFloat M_TimeToSlideNeededF { get; set;}

		[RED("m_TimeToSlideCurF")] 		public CFloat M_TimeToSlideCurF { get; set;}

		[RED("m_CameraExtraOffsetF")] 		public CFloat M_CameraExtraOffsetF { get; set;}

		[RED("m_CameraOffsetExtraVertLowF")] 		public CFloat M_CameraOffsetExtraVertLowF { get; set;}

		[RED("m_CameraOffsetExtraVertHighF")] 		public CFloat M_CameraOffsetExtraVertHighF { get; set;}

		[RED("m_CameraOffsetBlend")] 		public CFloat M_CameraOffsetBlend { get; set;}

		[RED("m_CameraOffsetVertF")] 		public CFloat M_CameraOffsetVertF { get; set;}

		[RED("m_CurentCameraAnimationN")] 		public CName M_CurentCameraAnimationN { get; set;}

		[RED("m_CameraAnimIdleS")] 		public SCameraAnimationData M_CameraAnimIdleS { get; set;}

		[RED("m_CameraAnimWalkS")] 		public SCameraAnimationData M_CameraAnimWalkS { get; set;}

		[RED("m_CameraAnimRunS")] 		public SCameraAnimationData M_CameraAnimRunS { get; set;}

		[RED("m_CameraAnimSprintS")] 		public SCameraAnimationData M_CameraAnimSprintS { get; set;}

		public CExplorationStateIdle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateIdle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}