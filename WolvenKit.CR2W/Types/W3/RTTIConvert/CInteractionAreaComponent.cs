using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInteractionAreaComponent : CComponent
	{
		[RED("rangeMin")] 		public CFloat RangeMin { get; set;}

		[RED("rangeMax")] 		public CFloat RangeMax { get; set;}

		[RED("rangeAngle")] 		public CUInt32 RangeAngle { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("isPlayerOnly")] 		public CBool IsPlayerOnly { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("manualTestingOnly")] 		public CBool ManualTestingOnly { get; set;}

		[RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[RED("alwaysVisibleRange")] 		public CFloat AlwaysVisibleRange { get; set;}

		[RED("lineOfSightOffset")] 		public Vector LineOfSightOffset { get; set;}

		[RED("performScriptedTest")] 		public CBool PerformScriptedTest { get; set;}

		public CInteractionAreaComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CInteractionAreaComponent(cr2w);

	}
}