using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayAdditiveLevel : CVariable
	{
		[RED("useLevel")] 		public CBool UseLevel { get; set;}

		[RED("synchronize")] 		public CBool Synchronize { get; set;}

		[RED("animations", 2,0)] 		public CArray<SGameplayAdditiveAnimation> Animations { get; set;}

		public SGameplayAdditiveLevel(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SGameplayAdditiveLevel(cr2w);

	}
}