using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateRoll : CExplorationStateAbstract
	{
		[RED("m_TimeSafetyEndF")] 		public CFloat M_TimeSafetyEndF { get; set;}

		[RED("m_OrientationSpeedF")] 		public CFloat M_OrientationSpeedF { get; set;}

		[RED("m_AutoRollB")] 		public CBool M_AutoRollB { get; set;}

		[RED("m_RollMinHeightF")] 		public CFloat M_RollMinHeightF { get; set;}

		[RED("m_RollTimeAfterF")] 		public CFloat M_RollTimeAfterF { get; set;}

		[RED("m_BehLandRunS")] 		public CName M_BehLandRunS { get; set;}

		[RED("m_BehLandCancelN")] 		public CName M_BehLandCancelN { get; set;}

		[RED("m_BehLandCanEndN")] 		public CName M_BehLandCanEndN { get; set;}

		[RED("m_BehLandCanFallN")] 		public CName M_BehLandCanFallN { get; set;}

		[RED("m_SlideTimeToDecideF")] 		public CFloat M_SlideTimeToDecideF { get; set;}

		[RED("verticalMovementParams")] 		public SVerticalMovementParams VerticalMovementParams { get; set;}

		[RED("m_TimeBeforeChainJumpF")] 		public CFloat M_TimeBeforeChainJumpF { get; set;}

		public CExplorationStateRoll(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateRoll(cr2w);

	}
}