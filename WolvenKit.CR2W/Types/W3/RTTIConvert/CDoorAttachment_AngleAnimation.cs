using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDoorAttachment_AngleAnimation : IDoorAttachment
	{
		[Ordinal(1)] [RED("openTime")] 		public CFloat OpenTime { get; set;}

		[Ordinal(2)] [RED("originalAngle")] 		public CFloat OriginalAngle { get; set;}

		public CDoorAttachment_AngleAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDoorAttachment_AngleAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}