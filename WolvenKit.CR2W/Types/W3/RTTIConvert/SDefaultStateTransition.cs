using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDefaultStateTransition : CVariable
	{
		[RED("m_StateNameN")] 		public CName M_StateNameN { get; set;}

		[RED("m_TimeToStartCheckingF")] 		public CFloat M_TimeToStartCheckingF { get; set;}

		public SDefaultStateTransition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SDefaultStateTransition(cr2w);

	}
}