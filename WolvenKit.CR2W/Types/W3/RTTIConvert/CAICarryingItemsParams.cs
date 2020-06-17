using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICarryingItemsParams : CAINpcWanderParams
	{
		[RED("storePointTag")] 		public CName StorePointTag { get; set;}

		[RED("carryingArea")] 		public EntityHandle CarryingArea { get; set;}

		[RED("dropItemOnDeactivation")] 		public CBool DropItemOnDeactivation { get; set;}

		public CAICarryingItemsParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAICarryingItemsParams(cr2w);

	}
}