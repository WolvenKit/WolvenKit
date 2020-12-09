using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterIdleFlyOnCurveParamsDefault : CAIMonsterIdleActionParams
	{
		[Ordinal(1)] [RED("curveTag")] 		public CName CurveTag { get; set;}

		[Ordinal(2)] [RED("rotateBeforeTakeOff")] 		public CBool RotateBeforeTakeOff { get; set;}

		[Ordinal(3)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(4)] [RED("curveDummyName")] 		public CString CurveDummyName { get; set;}

		[Ordinal(5)] [RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[Ordinal(6)] [RED("slotAnimation")] 		public CName SlotAnimation { get; set;}

		[Ordinal(7)] [RED("animValPitch")] 		public CString AnimValPitch { get; set;}

		[Ordinal(8)] [RED("animValYaw")] 		public CString AnimValYaw { get; set;}

		[Ordinal(9)] [RED("maxPitchInput")] 		public CFloat MaxPitchInput { get; set;}

		[Ordinal(10)] [RED("maxPitchOutput")] 		public CFloat MaxPitchOutput { get; set;}

		[Ordinal(11)] [RED("maxYawInput")] 		public CFloat MaxYawInput { get; set;}

		[Ordinal(12)] [RED("maxYawOutput")] 		public CFloat MaxYawOutput { get; set;}

		public CAIMonsterIdleFlyOnCurveParamsDefault(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterIdleFlyOnCurveParamsDefault(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}