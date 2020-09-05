using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescDialogShot : CVariable
	{
		[Ordinal(1)] [RED("shotId")] 		public CString ShotId { get; set;}

		[Ordinal(2)] [RED("infoShotname")] 		public CString InfoShotname { get; set;}

		[Ordinal(3)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("lines", 2,0)] 		public CArray<SSbDescDialogLine> Lines { get; set;}

		[Ordinal(5)] [RED("infoAnimId")] 		public CString InfoAnimId { get; set;}

		public SSbDescDialogShot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescDialogShot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}