using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTCollisionResponse : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("headingImportanceMin")] 		public CFloat HeadingImportanceMin { get; set;}

		[Ordinal(2)] [RED("headingImportanceMax")] 		public CFloat HeadingImportanceMax { get; set;}

		[Ordinal(3)] [RED("radiusMult")] 		public CFloat RadiusMult { get; set;}

		public CMoveSTCollisionResponse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTCollisionResponse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}