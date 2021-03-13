using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkullPileEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("factName")] 		public CString FactName { get; set;}

		[Ordinal(2)] [RED("tagToCollideWith")] 		public CName TagToCollideWith { get; set;}

		[Ordinal(3)] [RED("intact")] 		public CBool Intact { get; set;}

		[Ordinal(4)] [RED("destructionComp")] 		public CHandle<CDestructionSystemComponent> DestructionComp { get; set;}

		public CSkullPileEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkullPileEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}