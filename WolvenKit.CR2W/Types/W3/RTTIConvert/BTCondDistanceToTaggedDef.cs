using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondDistanceToTaggedDef : IBehTreeConditionalTaskDefinition
	{
		[RED("minDistance")] 		public CBehTreeValFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CBehTreeValFloat MaxDistance { get; set;}

		[RED("targetTag")] 		public CBehTreeValCName TargetTag { get; set;}

		public BTCondDistanceToTaggedDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondDistanceToTaggedDef(cr2w);

	}
}