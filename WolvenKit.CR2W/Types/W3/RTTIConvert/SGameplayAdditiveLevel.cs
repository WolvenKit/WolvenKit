using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayAdditiveLevel : CVariable
	{
		[Ordinal(1)] [RED("("useLevel")] 		public CBool UseLevel { get; set;}

		[Ordinal(2)] [RED("("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(3)] [RED("("animations", 2,0)] 		public CArray<SGameplayAdditiveAnimation> Animations { get; set;}

		public SGameplayAdditiveLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayAdditiveLevel(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}