using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlyOnCurve : IFlightActionTree
	{
		[Ordinal(0)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(0)] [RED("curveTag")] 		public CName CurveTag { get; set;}

		[Ordinal(0)] [RED("curveDummyName")] 		public CString CurveDummyName { get; set;}

		[Ordinal(0)] [RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[Ordinal(0)] [RED("slotAnimation")] 		public CName SlotAnimation { get; set;}

		[Ordinal(0)] [RED("animValPitch")] 		public CString AnimValPitch { get; set;}

		[Ordinal(0)] [RED("animValYaw")] 		public CString AnimValYaw { get; set;}

		[Ordinal(0)] [RED("maxPitchInput")] 		public CFloat MaxPitchInput { get; set;}

		[Ordinal(0)] [RED("maxPitchOutput")] 		public CFloat MaxPitchOutput { get; set;}

		[Ordinal(0)] [RED("maxYawInput")] 		public CFloat MaxYawInput { get; set;}

		[Ordinal(0)] [RED("maxYawOutput")] 		public CFloat MaxYawOutput { get; set;}

		public CAIFlyOnCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlyOnCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}