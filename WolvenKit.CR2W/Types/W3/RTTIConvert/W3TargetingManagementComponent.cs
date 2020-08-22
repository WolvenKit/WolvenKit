using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TargetingManagementComponent : CSelfUpdatingComponent
	{
		[RED("aimVector")] 		public Vector AimVector { get; set;}

		[RED("iconOffset")] 		public Vector IconOffset { get; set;}

		[RED("aimVectorSlot")] 		public CName AimVectorSlot { get; set;}

		[RED("iconOffsetSlot")] 		public CName IconOffsetSlot { get; set;}

		[RED("updatePosition")] 		public CBool UpdatePosition { get; set;}

		[RED("updateDelay")] 		public CFloat UpdateDelay { get; set;}

		[RED("m_LastUpdate")] 		public CFloat M_LastUpdate { get; set;}

		public W3TargetingManagementComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TargetingManagementComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}