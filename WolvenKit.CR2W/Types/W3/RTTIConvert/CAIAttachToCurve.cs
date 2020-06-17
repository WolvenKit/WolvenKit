using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAttachToCurve : IAIActionTree
	{
		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("curveTag")] 		public CName CurveTag { get; set;}

		[RED("curveDummyName")] 		public CString CurveDummyName { get; set;}

		[RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[RED("slotAnimation")] 		public CName SlotAnimation { get; set;}

		public CAIAttachToCurve(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIAttachToCurve(cr2w);

	}
}