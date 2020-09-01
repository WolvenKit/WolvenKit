using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphBoneInfo : CVariable
	{
		[Ordinal(0)] [RED("("m_boneName")] 		public CString M_boneName { get; set;}

		[Ordinal(0)] [RED("("m_weight")] 		public CFloat M_weight { get; set;}

		[Ordinal(0)] [RED("("num")] 		public CInt32 Num { get; set;}

		public SBehaviorGraphBoneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorGraphBoneInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}