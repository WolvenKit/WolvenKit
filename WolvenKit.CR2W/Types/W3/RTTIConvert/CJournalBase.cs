using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalBase : CObject
	{
		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("baseName")] 		public CString BaseName { get; set;}

		[RED("order")] 		public CUInt32 Order { get; set;}

		[RED("uniqueScriptIdentifier")] 		public CName UniqueScriptIdentifier { get; set;}

		public CJournalBase(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalBase(cr2w);

	}
}