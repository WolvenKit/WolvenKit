using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEntityTemplateCookedEffect : CVariable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("animName")] 		public CName AnimName { get; set;}

		[RED("buffer")] 		public SharedDataBuffer Buffer { get; set;}

		public CEntityTemplateCookedEffect(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEntityTemplateCookedEffect(cr2w);

	}
}