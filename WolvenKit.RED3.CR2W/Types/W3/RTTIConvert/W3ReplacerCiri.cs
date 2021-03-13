using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReplacerCiri : W3Replacer
	{
		[Ordinal(1)] [RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		[Ordinal(2)] [RED("ciriPhantoms", 2,0)] 		public CArray<CHandle<W3CiriPhantom>> CiriPhantoms { get; set;}

		[Ordinal(3)] [RED("bloodExplode")] 		public CHandle<CEntityTemplate> BloodExplode { get; set;}

		[Ordinal(4)] [RED("rageEffectEnabled")] 		public CBool RageEffectEnabled { get; set;}

		[Ordinal(5)] [RED("tempIsCollisionDisabled")] 		public CBool TempIsCollisionDisabled { get; set;}

		[Ordinal(6)] [RED("collidedEnemies", 2,0)] 		public CArray<CHandle<CActor>> CollidedEnemies { get; set;}

		[Ordinal(7)] [RED("slidingToNewPosition")] 		public CBool SlidingToNewPosition { get; set;}

		[Ordinal(8)] [RED("cameraDesiredHeading")] 		public Vector CameraDesiredHeading { get; set;}

		public W3ReplacerCiri(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ReplacerCiri(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}