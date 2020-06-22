using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationClimbOracle : CObject
	{
		[RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[RED("probeTop")] 		public CHandle<CClimbProbe> ProbeTop { get; set;}

		[RED("probeBottom")] 		public CHandle<CClimbProbe> ProbeBottom { get; set;}

		[RED("distForwardToCheck")] 		public CFloat DistForwardToCheck { get; set;}

		[RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[RED("characterHeight")] 		public CFloat CharacterHeight { get; set;}

		[RED("radiusToCheck")] 		public CFloat RadiusToCheck { get; set;}

		[RED("bottomCheckAllowed")] 		public CBool BottomCheckAllowed { get; set;}

		[RED("topIsPriority")] 		public CBool TopIsPriority { get; set;}

		[RED("probeBeingUsed")] 		public CEnum<EClimbProbeUsed> ProbeBeingUsed { get; set;}

		[RED("debugLogFails")] 		public CBool DebugLogFails { get; set;}

		[RED("vectorUp")] 		public Vector VectorUp { get; set;}

		public CExplorationClimbOracle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationClimbOracle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}