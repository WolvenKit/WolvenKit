using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CThrowable : CProjectileTrajectory
	{
		[Ordinal(1)] [RED("ownerHandle")] 		public EntityHandle OwnerHandle { get; set;}

		[Ordinal(2)] [RED("wasThrown")] 		public CBool WasThrown { get; set;}

		[Ordinal(3)] [RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[Ordinal(4)] [RED("isFromAimThrow")] 		public CBool IsFromAimThrow { get; set;}

		public CThrowable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CThrowable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}