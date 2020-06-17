using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInGameConfigBufferedEntry : CVariable
	{
		[RED("groupName")] 		public CName GroupName { get; set;}

		[RED("varName")] 		public CName VarName { get; set;}

		[RED("varValue")] 		public CString VarValue { get; set;}

		[RED("startValue")] 		public CString StartValue { get; set;}

		public SInGameConfigBufferedEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SInGameConfigBufferedEntry(cr2w);

	}
}