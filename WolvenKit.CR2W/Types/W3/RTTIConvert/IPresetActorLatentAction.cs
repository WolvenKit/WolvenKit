using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IPresetActorLatentAction : IActorLatentAction
	{
		[RED("res")] 		public CHandle<CBehTree> Res { get; set;}

		[RED("def")] 		public CPtr<CBehTreeNodeTemplateDefinition> Def { get; set;}

		[RED("resName")] 		public CString ResName { get; set;}

		public IPresetActorLatentAction(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new IPresetActorLatentAction(cr2w);

	}
}