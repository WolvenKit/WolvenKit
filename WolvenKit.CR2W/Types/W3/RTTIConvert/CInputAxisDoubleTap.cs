using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInputAxisDoubleTap : CObject
	{
		[RED("m_ActionN")] 		public CName M_ActionN { get; set;}

		[RED("m_ThresholdUnpressF")] 		public CFloat M_ThresholdUnpressF { get; set;}

		[RED("m_ThresholdPressF")] 		public CFloat M_ThresholdPressF { get; set;}

		[RED("m_TimeThresholdF")] 		public CFloat M_TimeThresholdF { get; set;}

		public CInputAxisDoubleTap(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CInputAxisDoubleTap(cr2w);

	}
}