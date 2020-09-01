using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ArrowProjectile : W3AdvancedProjectile
	{
		[Ordinal(0)] [RED("("defaultTrail")] 		public CName DefaultTrail { get; set;}

		[Ordinal(0)] [RED("("underwaterTrail")] 		public CName UnderwaterTrail { get; set;}

		[Ordinal(0)] [RED("("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("("activeTrail")] 		public CName ActiveTrail { get; set;}

		[Ordinal(0)] [RED("("shouldBeAttachedToVictim")] 		public CBool ShouldBeAttachedToVictim { get; set;}

		[Ordinal(0)] [RED("("isOnFire")] 		public CBool IsOnFire { get; set;}

		[Ordinal(0)] [RED("("isUnderwater")] 		public CBool IsUnderwater { get; set;}

		[Ordinal(0)] [RED("("isBouncedArrow")] 		public CBool IsBouncedArrow { get; set;}

		[Ordinal(0)] [RED("("isScheduledForDestruction")] 		public CBool IsScheduledForDestruction { get; set;}

		public W3ArrowProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ArrowProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}