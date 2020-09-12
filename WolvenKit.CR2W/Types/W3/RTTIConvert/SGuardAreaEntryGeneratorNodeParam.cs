using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGuardAreaEntryGeneratorNodeParam : CVariable
	{
		[Ordinal(1)] [RED("guardAreaTag")] 		public CName GuardAreaTag { get; set;}

		[Ordinal(2)] [RED("pursuitAreaTag")] 		public CName PursuitAreaTag { get; set;}

		[Ordinal(3)] [RED("pursuitRange")] 		public CFloat PursuitRange { get; set;}

		public SGuardAreaEntryGeneratorNodeParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGuardAreaEntryGeneratorNodeParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}