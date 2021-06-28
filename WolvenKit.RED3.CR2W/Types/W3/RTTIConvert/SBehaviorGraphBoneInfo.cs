using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphBoneInfo : CVariable
	{
		[Ordinal(1)] [RED("m_boneName")] 		public CString M_boneName { get; set;}

		[Ordinal(2)] [RED("m_weight")] 		public CFloat M_weight { get; set;}

		[Ordinal(3)] [RED("num")] 		public CInt32 Num { get; set;}

		public SBehaviorGraphBoneInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}