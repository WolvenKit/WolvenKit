using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateIdle : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("m_SubStateLasE")] 		public CEnum<EPlayerIdleSubstate> M_SubStateLasE { get; set;}

		[Ordinal(2)] [RED("m_SubStateE")] 		public CEnum<EPlayerIdleSubstate> M_SubStateE { get; set;}

		[Ordinal(3)] [RED("m_SpeedMaxConsideredSprintF")] 		public CFloat M_SpeedMaxConsideredSprintF { get; set;}

		[Ordinal(4)] [RED("m_SpeedMaxConsideredRunF")] 		public CFloat M_SpeedMaxConsideredRunF { get; set;}

		[Ordinal(5)] [RED("m_SpeedMaxConsideredWalkF")] 		public CFloat M_SpeedMaxConsideredWalkF { get; set;}

		[Ordinal(6)] [RED("m_FallSpeedCoefF")] 		public CFloat M_FallSpeedCoefF { get; set;}

		[Ordinal(7)] [RED("m_FallExtraVerticalImpulseF")] 		public CFloat M_FallExtraVerticalImpulseF { get; set;}

		[Ordinal(8)] [RED("m_FallHorizontalImpulseF")] 		public CFloat M_FallHorizontalImpulseF { get; set;}

		[Ordinal(9)] [RED("m_FallHorizontalImpulseCancelF")] 		public CFloat M_FallHorizontalImpulseCancelF { get; set;}

		[Ordinal(10)] [RED("m_TimeToSlideNeededF")] 		public CFloat M_TimeToSlideNeededF { get; set;}

		[Ordinal(11)] [RED("m_TimeToSlideCurF")] 		public CFloat M_TimeToSlideCurF { get; set;}

		[Ordinal(12)] [RED("m_CameraExtraOffsetF")] 		public CFloat M_CameraExtraOffsetF { get; set;}

		[Ordinal(13)] [RED("m_CameraOffsetExtraVertLowF")] 		public CFloat M_CameraOffsetExtraVertLowF { get; set;}

		[Ordinal(14)] [RED("m_CameraOffsetExtraVertHighF")] 		public CFloat M_CameraOffsetExtraVertHighF { get; set;}

		[Ordinal(15)] [RED("m_CameraOffsetBlend")] 		public CFloat M_CameraOffsetBlend { get; set;}

		[Ordinal(16)] [RED("m_CameraOffsetVertF")] 		public CFloat M_CameraOffsetVertF { get; set;}

		[Ordinal(17)] [RED("m_CurentCameraAnimationN")] 		public CName M_CurentCameraAnimationN { get; set;}

		[Ordinal(18)] [RED("m_CameraAnimIdleS")] 		public SCameraAnimationData M_CameraAnimIdleS { get; set;}

		[Ordinal(19)] [RED("m_CameraAnimWalkS")] 		public SCameraAnimationData M_CameraAnimWalkS { get; set;}

		[Ordinal(20)] [RED("m_CameraAnimRunS")] 		public SCameraAnimationData M_CameraAnimRunS { get; set;}

		[Ordinal(21)] [RED("m_CameraAnimSprintS")] 		public SCameraAnimationData M_CameraAnimSprintS { get; set;}

		public CExplorationStateIdle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateIdle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}