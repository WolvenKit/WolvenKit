using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskMaintainDistanceDef : IBehTreeTaskDefinition
	{
		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("faceTarget")] 		public CBool FaceTarget { get; set;}

		[RED("fromOutsideDuration")] 		public CFloat FromOutsideDuration { get; set;}

		[RED("forceTarget")] 		public CName ForceTarget { get; set;}

		public BTTaskMaintainDistanceDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskMaintainDistanceDef(cr2w);

	}
}