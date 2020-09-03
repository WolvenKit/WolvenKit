using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBgNpcItemComponent : CBgMeshComponent
	{
		[Ordinal(1)] [RED("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(2)] [RED("itemCategory")] 		public CName ItemCategory { get; set;}

		[Ordinal(3)] [RED("defaultState")] 		public CEnum<EItemState> DefaultState { get; set;}

		[Ordinal(4)] [RED("equipSlot")] 		public CName EquipSlot { get; set;}

		[Ordinal(5)] [RED("holdSlot")] 		public CName HoldSlot { get; set;}

		public CBgNpcItemComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBgNpcItemComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}