using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestEntityMotionBlock : CQuestGraphBlock
	{
		[RED("entityTag")] 		public CName EntityTag { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("targetTransform")] 		public EngineTransform TargetTransform { get; set;}

		[RED("positionDelta")] 		public Vector PositionDelta { get; set;}

		[RED("rotationDelta")] 		public EulerAngles RotationDelta { get; set;}

		[RED("scaleDelta")] 		public Vector ScaleDelta { get; set;}

		[RED("animationCurve")] 		public SSimpleCurve AnimationCurve { get; set;}

		public CQuestEntityMotionBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestEntityMotionBlock(cr2w);

	}
}