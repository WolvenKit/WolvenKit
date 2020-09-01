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
		[Ordinal(0)] [RED("projectileTemplate")] 		public CHandle<CEntityTemplate> ProjectileTemplate { get; set;}

		[Ordinal(0)] [RED("proj")] 		public CHandle<W3AdvancedProjectile> Proj { get; set;}

		[Ordinal(0)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(0)] [RED("angleDist")] 		public CFloat AngleDist { get; set;}

		[Ordinal(0)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(0)] [RED("pickUp")] 		public CBool PickUp { get; set;}

		[Ordinal(0)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(0)] [RED("physicalComponent")] 		public CHandle<CComponent> PhysicalComponent { get; set;}

		[Ordinal(0)] [RED("wantedHeadingVec")] 		public Vector WantedHeadingVec { get; set;}

		public CBTTaskPickUpAndThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPickUpAndThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}