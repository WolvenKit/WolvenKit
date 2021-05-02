using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInGameConfigBufferedEntry : CVariable
	{
		[Ordinal(1)] [RED("groupName")] 		public CName GroupName { get; set;}

		[Ordinal(2)] [RED("varName")] 		public CName VarName { get; set;}

		[Ordinal(3)] [RED("varValue")] 		public CString VarValue { get; set;}

		[Ordinal(4)] [RED("startValue")] 		public CString StartValue { get; set;}

		public SInGameConfigBufferedEntry(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SInGameConfigBufferedEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}