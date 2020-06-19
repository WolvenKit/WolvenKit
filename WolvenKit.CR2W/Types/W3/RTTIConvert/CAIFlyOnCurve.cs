using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlyOnCurve : IFlightActionTree
	{
		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("curveTag")] 		public CName CurveTag { get; set;}

		[RED("curveDummyName")] 		public CString CurveDummyName { get; set;}

		[RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[RED("slotAnimation")] 		public CName SlotAnimation { get; set;}

		[RED("animValPitch")] 		public CString AnimValPitch { get; set;}

		[RED("animValYaw")] 		public CString AnimValYaw { get; set;}

		[RED("maxPitchInput")] 		public CFloat MaxPitchInput { get; set;}

		[RED("maxPitchOutput")] 		public CFloat MaxPitchOutput { get; set;}

		[RED("maxYawInput")] 		public CFloat MaxYawInput { get; set;}

		[RED("maxYawOutput")] 		public CFloat MaxYawOutput { get; set;}

		public CAIFlyOnCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlyOnCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}