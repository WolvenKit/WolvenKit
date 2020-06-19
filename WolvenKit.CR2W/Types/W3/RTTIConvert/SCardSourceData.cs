using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCardSourceData : CVariable
	{
		[RED("cardName")] 		public CName CardName { get; set;}

		[RED("source")] 		public CString Source { get; set;}

		[RED("originArea")] 		public CString OriginArea { get; set;}

		[RED("originQuest")] 		public CString OriginQuest { get; set;}

		[RED("details")] 		public CString Details { get; set;}

		[RED("coords")] 		public CString Coords { get; set;}

		public SCardSourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCardSourceData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}