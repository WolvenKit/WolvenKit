using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondIsInTheWayDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("origin")] 		public CEnum<ETargetName> Origin { get; set;}

		[Ordinal(2)] [RED("obstacle")] 		public CEnum<ETargetName> Obstacle { get; set;}

		[Ordinal(3)] [RED("destination")] 		public CEnum<ETargetName> Destination { get; set;}

		[Ordinal(4)] [RED("requiredDistanceFromLine")] 		public CFloat RequiredDistanceFromLine { get; set;}

		[Ordinal(5)] [RED("returnIfInvalid")] 		public CBool ReturnIfInvalid { get; set;}

		public BTCondIsInTheWayDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondIsInTheWayDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}