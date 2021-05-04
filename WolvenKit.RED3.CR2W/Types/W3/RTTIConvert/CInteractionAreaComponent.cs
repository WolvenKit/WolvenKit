using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInteractionAreaComponent : CComponent
	{
		[Ordinal(1)] [RED("rangeMin")] 		public CFloat RangeMin { get; set;}

		[Ordinal(2)] [RED("rangeMax")] 		public CFloat RangeMax { get; set;}

		[Ordinal(3)] [RED("rangeAngle")] 		public CUInt32 RangeAngle { get; set;}

		[Ordinal(4)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(5)] [RED("isPlayerOnly")] 		public CBool IsPlayerOnly { get; set;}

		[Ordinal(6)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(7)] [RED("manualTestingOnly")] 		public CBool ManualTestingOnly { get; set;}

		[Ordinal(8)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(9)] [RED("alwaysVisibleRange")] 		public CFloat AlwaysVisibleRange { get; set;}

		[Ordinal(10)] [RED("lineOfSightOffset")] 		public Vector LineOfSightOffset { get; set;}

		[Ordinal(11)] [RED("performScriptedTest")] 		public CBool PerformScriptedTest { get; set;}

		public CInteractionAreaComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}