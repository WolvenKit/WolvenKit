using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDoorSoundsEvents : CVariable
	{
		[Ordinal(1)] [RED("("open")] 		public CString Open { get; set;}

		[Ordinal(2)] [RED("("openFully")] 		public CString OpenFully { get; set;}

		[Ordinal(3)] [RED("("openingStart")] 		public CString OpeningStart { get; set;}

		[Ordinal(4)] [RED("("openingStop")] 		public CString OpeningStop { get; set;}

		[Ordinal(5)] [RED("("close")] 		public CString Close { get; set;}

		[Ordinal(6)] [RED("("closeFully")] 		public CString CloseFully { get; set;}

		[Ordinal(7)] [RED("("closingStart")] 		public CString ClosingStart { get; set;}

		[Ordinal(8)] [RED("("closingStop")] 		public CString ClosingStop { get; set;}

		public SDoorSoundsEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDoorSoundsEvents(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}