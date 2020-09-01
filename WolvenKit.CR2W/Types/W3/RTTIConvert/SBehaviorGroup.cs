using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGroup : CObject
	{
		[Ordinal(1)] [RED("("behavior")] 		public CSoft<CBehaviorGraph> Behavior { get; set;}

		[Ordinal(2)] [RED("("affectedNPCs")] 		public TagList AffectedNPCs { get; set;}

		[Ordinal(3)] [RED("("expectedCount")] 		public CUInt32 ExpectedCount { get; set;}

		public SBehaviorGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}