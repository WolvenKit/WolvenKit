using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ApertureDofParams : CVariable
	{
		[RED("aperture")] 		public CEnum<EApertureValue> Aperture { get; set;}

		[RED("focalLength")] 		public CFloat FocalLength { get; set;}

		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		public ApertureDofParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ApertureDofParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}