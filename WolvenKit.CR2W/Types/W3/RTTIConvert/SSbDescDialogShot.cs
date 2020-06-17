using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescDialogShot : CVariable
	{
		[RED("shotId")] 		public CString ShotId { get; set;}

		[RED("infoShotname")] 		public CString InfoShotname { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("lines", 2,0)] 		public CArray<SSbDescDialogLine> Lines { get; set;}

		[RED("infoAnimId")] 		public CString InfoAnimId { get; set;}

		public SSbDescDialogShot(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSbDescDialogShot(cr2w);

	}
}