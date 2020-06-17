using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationSharedData : CObject
	{
		[RED("m_SprintJumpTimePreparingF")] 		public CFloat M_SprintJumpTimePreparingF { get; set;}

		[RED("m_BehParamRightFootS")] 		public CName M_BehParamRightFootS { get; set;}

		[RED("m_UsePantherJumpB")] 		public CBool M_UsePantherJumpB { get; set;}

		[RED("m_AirCollisionSideEnabledB")] 		public CBool M_AirCollisionSideEnabledB { get; set;}

		[RED("m_SkateGlobalC")] 		public CHandle<CExplorationSkatingGlobal> M_SkateGlobalC { get; set;}

		[RED("landAddCurve")] 		public CHandle<CCurve> LandAddCurve { get; set;}

		[RED("landAddCoefWalk")] 		public CFloat LandAddCoefWalk { get; set;}

		[RED("landAddTimeCoefWalk")] 		public CFloat LandAddTimeCoefWalk { get; set;}

		[RED("landAddSpeedCancel")] 		public CFloat LandAddSpeedCancel { get; set;}

		[RED("landAddTimeCoefFast")] 		public CFloat LandAddTimeCoefFast { get; set;}

		[RED("landAddBehVarName")] 		public CName LandAddBehVarName { get; set;}

		[RED("m_CameraModifyOffsetB")] 		public CBool M_CameraModifyOffsetB { get; set;}

		public CExplorationSharedData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationSharedData(cr2w);

	}
}