using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAbility : CVariable
	{
		[Ordinal(1)] [RED("attributes", 2,0)] 		public CArray<SAbilityAttribute> Attributes { get; set;}

		[Ordinal(2)] [RED("prerequisites", 2,0)] 		public CArray<CName> Prerequisites { get; set;}

		[Ordinal(3)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(4)] [RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[Ordinal(5)] [RED("type")] 		public CInt32 Type { get; set;}

		public SAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAbility(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}