using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDoorSoundsEvents : CVariable
	{
		[RED("open")] 		public CString Open { get; set;}

		[RED("openFully")] 		public CString OpenFully { get; set;}

		[RED("openingStart")] 		public CString OpeningStart { get; set;}

		[RED("openingStop")] 		public CString OpeningStop { get; set;}

		[RED("close")] 		public CString Close { get; set;}

		[RED("closeFully")] 		public CString CloseFully { get; set;}

		[RED("closingStart")] 		public CString ClosingStart { get; set;}

		[RED("closingStop")] 		public CString ClosingStop { get; set;}

		public SDoorSoundsEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDoorSoundsEvents(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}