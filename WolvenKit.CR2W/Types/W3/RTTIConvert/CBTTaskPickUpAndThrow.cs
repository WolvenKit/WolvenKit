using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPickUpAndThrow : IBehTreeTask
	{
		[RED("projectileTemplate")] 		public CHandle<CEntityTemplate> ProjectileTemplate { get; set;}

		[RED("proj")] 		public CHandle<W3AdvancedProjectile> Proj { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("tag")] 		public CName Tag { get; set;}

		[RED("angleDist")] 		public CFloat AngleDist { get; set;}

		[RED("slotName")] 		public CName SlotName { get; set;}

		[RED("pickUp")] 		public CBool PickUp { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[RED("physicalComponent")] 		public CHandle<CComponent> PhysicalComponent { get; set;}

		[RED("wantedHeadingVec")] 		public Vector WantedHeadingVec { get; set;}

		public CBTTaskPickUpAndThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPickUpAndThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}