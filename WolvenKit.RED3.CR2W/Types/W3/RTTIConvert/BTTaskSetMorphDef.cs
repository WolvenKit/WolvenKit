using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSetMorphDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("morphOnAnimEvent")] 		public CBool MorphOnAnimEvent { get; set;}

		[Ordinal(2)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(3)] [RED("ratio")] 		public CFloat Ratio { get; set;}

		[Ordinal(4)] [RED("morphOnActivate")] 		public CBool MorphOnActivate { get; set;}

		[Ordinal(5)] [RED("ratioOnActivate")] 		public CFloat RatioOnActivate { get; set;}

		[Ordinal(6)] [RED("timeOnActivate")] 		public CFloat TimeOnActivate { get; set;}

		[Ordinal(7)] [RED("morphOnDeactivate")] 		public CBool MorphOnDeactivate { get; set;}

		[Ordinal(8)] [RED("ratioOnDeactivate")] 		public CFloat RatioOnDeactivate { get; set;}

		[Ordinal(9)] [RED("timeOnDeactivate")] 		public CFloat TimeOnDeactivate { get; set;}

		public BTTaskSetMorphDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSetMorphDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}