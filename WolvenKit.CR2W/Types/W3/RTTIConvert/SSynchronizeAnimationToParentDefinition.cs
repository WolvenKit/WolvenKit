using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSynchronizeAnimationToParentDefinition : CVariable
	{
		[RED("Parent animation")] 		public CName Parent_animation { get; set;}

		[RED("Play animation")] 		public CName Play_animation { get; set;}

		public SSynchronizeAnimationToParentDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSynchronizeAnimationToParentDefinition(cr2w);

	}
}