using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayAdditiveLevel : CVariable
	{
		[Ordinal(1)] [RED("useLevel")] 		public CBool UseLevel { get; set;}

		[Ordinal(2)] [RED("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(3)] [RED("animations", 2,0)] 		public CArray<SGameplayAdditiveAnimation> Animations { get; set;}

		public SGameplayAdditiveLevel(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}