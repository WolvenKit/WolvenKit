using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICarryingItemsParams : CAINpcWanderParams
	{
		[Ordinal(1)] [RED("storePointTag")] 		public CName StorePointTag { get; set;}

		[Ordinal(2)] [RED("carryingArea")] 		public EntityHandle CarryingArea { get; set;}

		[Ordinal(3)] [RED("dropItemOnDeactivation")] 		public CBool DropItemOnDeactivation { get; set;}

		public CAICarryingItemsParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAICarryingItemsParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}