using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnDettlaffColumnsDef : IBehTreeTaskDefinition
	{
		[RED("amountToSpawn")] 		public CInt32 AmountToSpawn { get; set;}

		[RED("minDistanceFromTarget")] 		public CFloat MinDistanceFromTarget { get; set;}

		[RED("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[RED("tagToFind")] 		public CName TagToFind { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		public CBTTaskSpawnDettlaffColumnsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnDettlaffColumnsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}