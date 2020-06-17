using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimMorphEvent : CExtAnimDurationEvent
	{
		[RED("morphComponentId")] 		public CName MorphComponentId { get; set;}

		[RED("invertWeight")] 		public CBool InvertWeight { get; set;}

		[RED("useCurve")] 		public CBool UseCurve { get; set;}

		[RED("curve")] 		public SCurveData Curve { get; set;}

		public CExtAnimMorphEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExtAnimMorphEvent(cr2w);

	}
}