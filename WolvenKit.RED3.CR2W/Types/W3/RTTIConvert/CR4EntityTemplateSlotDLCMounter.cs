using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EntityTemplateSlotDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(1)] [RED("baseEntityTemplatePath")] 		public CString BaseEntityTemplatePath { get; set;}

		[Ordinal(2)] [RED("entityTemplatePaths", 2,0)] 		public CArray<CString> EntityTemplatePaths { get; set;}

		[Ordinal(3)] [RED("entityTemplateSlots", 2,0)] 		public CArray<CPtr<EntitySlot>> EntityTemplateSlots { get; set;}

		public CR4EntityTemplateSlotDLCMounter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}