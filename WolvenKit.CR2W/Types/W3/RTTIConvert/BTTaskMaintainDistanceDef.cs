using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskMaintainDistanceDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("faceTarget")] 		public CBool FaceTarget { get; set;}

		[Ordinal(4)] [RED("fromOutsideDuration")] 		public CFloat FromOutsideDuration { get; set;}

		[Ordinal(5)] [RED("forceTarget")] 		public CName ForceTarget { get; set;}

		public BTTaskMaintainDistanceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskMaintainDistanceDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}