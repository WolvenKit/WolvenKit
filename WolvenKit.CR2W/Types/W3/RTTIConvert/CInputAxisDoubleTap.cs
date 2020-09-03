using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInputAxisDoubleTap : CObject
	{
		[Ordinal(1)] [RED("m_ActionN")] 		public CName M_ActionN { get; set;}

		[Ordinal(2)] [RED("m_ThresholdUnpressF")] 		public CFloat M_ThresholdUnpressF { get; set;}

		[Ordinal(3)] [RED("m_ThresholdPressF")] 		public CFloat M_ThresholdPressF { get; set;}

		[Ordinal(4)] [RED("m_TimeThresholdF")] 		public CFloat M_TimeThresholdF { get; set;}

		[Ordinal(5)] [RED("m_IsActivatedB")] 		public CBool M_IsActivatedB { get; set;}

		[Ordinal(6)] [RED("m_PressedNowB")] 		public CBool M_PressedNowB { get; set;}

		[Ordinal(7)] [RED("m_UnpressedNowB")] 		public CBool M_UnpressedNowB { get; set;}

		[Ordinal(8)] [RED("m_TimeF")] 		public CFloat M_TimeF { get; set;}

		[Ordinal(9)] [RED("m_LastTimesUnpressFArr", 2,0)] 		public CArray<CFloat> M_LastTimesUnpressFArr { get; set;}

		[Ordinal(10)] [RED("m_LastTimesPressFArr", 2,0)] 		public CArray<CFloat> M_LastTimesPressFArr { get; set;}

		public CInputAxisDoubleTap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CInputAxisDoubleTap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}