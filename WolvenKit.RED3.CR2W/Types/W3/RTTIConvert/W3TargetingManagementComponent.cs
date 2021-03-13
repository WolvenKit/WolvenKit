using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TargetingManagementComponent : CSelfUpdatingComponent
	{
		[Ordinal(1)] [RED("aimVector")] 		public Vector AimVector { get; set;}

		[Ordinal(2)] [RED("iconOffset")] 		public Vector IconOffset { get; set;}

		[Ordinal(3)] [RED("aimVectorSlot")] 		public CName AimVectorSlot { get; set;}

		[Ordinal(4)] [RED("iconOffsetSlot")] 		public CName IconOffsetSlot { get; set;}

		[Ordinal(5)] [RED("updatePosition")] 		public CBool UpdatePosition { get; set;}

		[Ordinal(6)] [RED("updateDelay")] 		public CFloat UpdateDelay { get; set;}

		[Ordinal(7)] [RED("m_LastUpdate")] 		public CFloat M_LastUpdate { get; set;}

		public W3TargetingManagementComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TargetingManagementComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}