using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAnimalFleeDef : IBehTreeTaskDefinition
	{
		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("alertRadius")] 		public CFloat AlertRadius { get; set;}

		[RED("ignoreEntitiesWithTag")] 		public CName IgnoreEntitiesWithTag { get; set;}

		[RED("moveType")] 		public EMoveType MoveType { get; set;}

		public CBTTaskAnimalFleeDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskAnimalFleeDef(cr2w);

	}
}