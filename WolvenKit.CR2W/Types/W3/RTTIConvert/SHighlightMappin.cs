using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SHighlightMappin : CVariable
	{
		[RED("MappinName")] 		public CName MappinName { get; set;}

		[RED("MappinState")] 		public CBool MappinState { get; set;}

		public SHighlightMappin(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SHighlightMappin(cr2w);

	}
}