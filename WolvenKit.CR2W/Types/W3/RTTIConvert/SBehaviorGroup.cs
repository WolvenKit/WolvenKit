using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGroup : CObject
	{
		[RED("behavior")] 		public CSoft<CBehaviorGraph> Behavior { get; set;}

		[RED("affectedNPCs")] 		public TagList AffectedNPCs { get; set;}

		[RED("expectedCount")] 		public CUInt32 ExpectedCount { get; set;}

		public SBehaviorGroup(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorGroup(cr2w);

	}
}