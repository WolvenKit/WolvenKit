using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateRoll : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("m_TimeSafetyEndF")] 		public CFloat M_TimeSafetyEndF { get; set;}

		[Ordinal(2)] [RED("m_OrientationSpeedF")] 		public CFloat M_OrientationSpeedF { get; set;}

		[Ordinal(3)] [RED("m_AutoRollB")] 		public CBool M_AutoRollB { get; set;}

		[Ordinal(4)] [RED("m_RollMinHeightF")] 		public CFloat M_RollMinHeightF { get; set;}

		[Ordinal(5)] [RED("m_RollTimeAfterF")] 		public CFloat M_RollTimeAfterF { get; set;}

		[Ordinal(6)] [RED("m_ReadyToEndB")] 		public CBool M_ReadyToEndB { get; set;}

		[Ordinal(7)] [RED("m_ReadyToFallB")] 		public CBool M_ReadyToFallB { get; set;}

		[Ordinal(8)] [RED("m_BehLandRunS")] 		public CName M_BehLandRunS { get; set;}

		[Ordinal(9)] [RED("m_BehLandCancelN")] 		public CName M_BehLandCancelN { get; set;}

		[Ordinal(10)] [RED("m_BehLandCanEndN")] 		public CName M_BehLandCanEndN { get; set;}

		[Ordinal(11)] [RED("m_BehLandCanFallN")] 		public CName M_BehLandCanFallN { get; set;}

		[Ordinal(12)] [RED("m_SlidingB")] 		public CBool M_SlidingB { get; set;}

		[Ordinal(13)] [RED("m_SlideTimeToDecideF")] 		public CFloat M_SlideTimeToDecideF { get; set;}

		[Ordinal(14)] [RED("m_ToFallB")] 		public CBool M_ToFallB { get; set;}

		[Ordinal(15)] [RED("verticalMovementParams")] 		public SVerticalMovementParams VerticalMovementParams { get; set;}

		[Ordinal(16)] [RED("m_ToSlideB")] 		public CBool M_ToSlideB { get; set;}

		[Ordinal(17)] [RED("m_TimeBeforeChainJumpF")] 		public CFloat M_TimeBeforeChainJumpF { get; set;}

		public CExplorationStateRoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateRoll(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}