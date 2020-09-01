using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CreaturesGroupDef : CVariable
	{
		[Ordinal(1)] [RED("groupName")] 		public CName GroupName { get; set;}

		[Ordinal(2)] [RED("disabledBySources")] 		public CInt32 DisabledBySources { get; set;}

		[Ordinal(3)] [RED("sourcesNames", 2,0)] 		public CArray<CName> SourcesNames { get; set;}

		public CreaturesGroupDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CreaturesGroupDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}