using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReplacerCiri : W3Replacer
	{
		[RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		[RED("ciriPhantoms", 2,0)] 		public CArray<CHandle<W3CiriPhantom>> CiriPhantoms { get; set;}

		[RED("bloodExplode")] 		public CHandle<CEntityTemplate> BloodExplode { get; set;}

		[RED("rageEffectEnabled")] 		public CBool RageEffectEnabled { get; set;}

		[RED("tempIsCollisionDisabled")] 		public CBool TempIsCollisionDisabled { get; set;}

		[RED("collidedEnemies", 2,0)] 		public CArray<CHandle<CActor>> CollidedEnemies { get; set;}

		[RED("slidingToNewPosition")] 		public CBool SlidingToNewPosition { get; set;}

		[RED("cameraDesiredHeading")] 		public Vector CameraDesiredHeading { get; set;}

		public W3ReplacerCiri(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ReplacerCiri(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}