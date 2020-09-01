using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAnimalFleeDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("("alertRadius")] 		public CFloat AlertRadius { get; set;}

		[Ordinal(0)] [RED("("ignoreEntitiesWithTag")] 		public CName IgnoreEntitiesWithTag { get; set;}

		[Ordinal(0)] [RED("("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		public CBTTaskAnimalFleeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAnimalFleeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}