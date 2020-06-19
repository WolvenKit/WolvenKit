using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAddFactPerformableAction : IPerformableAction
	{
		[RED("factID")] 		public CString FactID { get; set;}

		[RED("value")] 		public CInt32 Value { get; set;}

		[RED("validForSeconds")] 		public CInt32 ValidForSeconds { get; set;}

		public CAddFactPerformableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAddFactPerformableAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}