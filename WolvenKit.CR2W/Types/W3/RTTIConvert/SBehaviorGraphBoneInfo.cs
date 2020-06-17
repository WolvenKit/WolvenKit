using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphBoneInfo : CVariable
	{
		[RED("m_boneName")] 		public CString M_boneName { get; set;}

		[RED("m_weight")] 		public CFloat M_weight { get; set;}

		[RED("num")] 		public CInt32 Num { get; set;}

		public SBehaviorGraphBoneInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorGraphBoneInfo(cr2w);

	}
}