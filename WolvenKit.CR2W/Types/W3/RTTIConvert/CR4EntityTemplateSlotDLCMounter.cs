using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EntityTemplateSlotDLCMounter : IGameplayDLCMounter
	{
		[RED("baseEntityTemplatePath")] 		public CString BaseEntityTemplatePath { get; set;}

		[RED("entityTemplatePaths", 2,0)] 		public CArray<CString> EntityTemplatePaths { get; set;}

		[RED("entityTemplateSlots", 2,0)] 		public CArray<CPtr<EntitySlot>> EntityTemplateSlots { get; set;}

		public CR4EntityTemplateSlotDLCMounter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4EntityTemplateSlotDLCMounter(cr2w);

	}
}