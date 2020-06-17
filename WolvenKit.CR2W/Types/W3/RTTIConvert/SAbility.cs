using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAbility : CVariable
	{
		[RED("attributes", 2,0)] 		public CArray<SAbilityAttribute> Attributes { get; set;}

		[RED("prerequisites", 2,0)] 		public CArray<CName> Prerequisites { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[RED("type")] 		public CInt32 Type { get; set;}

		public SAbility(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAbility(cr2w);

	}
}