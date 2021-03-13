using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPickUpAndThrow : IBehTreeTask
	{
		[Ordinal(1)] [RED("projectileTemplate")] 		public CHandle<CEntityTemplate> ProjectileTemplate { get; set;}

		[Ordinal(2)] [RED("proj")] 		public CHandle<W3AdvancedProjectile> Proj { get; set;}

		[Ordinal(3)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(4)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(5)] [RED("angleDist")] 		public CFloat AngleDist { get; set;}

		[Ordinal(6)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(7)] [RED("pickUp")] 		public CBool PickUp { get; set;}

		[Ordinal(8)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(9)] [RED("physicalComponent")] 		public CHandle<CComponent> PhysicalComponent { get; set;}

		[Ordinal(10)] [RED("wantedHeadingVec")] 		public Vector WantedHeadingVec { get; set;}

		public CBTTaskPickUpAndThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPickUpAndThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}