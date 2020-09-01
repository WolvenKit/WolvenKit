using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcDeathParams : CAIDeathParameters
	{
		[Ordinal(0)] [RED("createReactionEvent")] 		public CName CreateReactionEvent { get; set;}

		[Ordinal(0)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(0)] [RED("playFXOnActivate")] 		public CName PlayFXOnActivate { get; set;}

		[Ordinal(0)] [RED("playFXOnDeactivate")] 		public CName PlayFXOnDeactivate { get; set;}

		[Ordinal(0)] [RED("stopFXOnActivate")] 		public CName StopFXOnActivate { get; set;}

		[Ordinal(0)] [RED("stopFXOnDeactivate")] 		public CName StopFXOnDeactivate { get; set;}

		[Ordinal(0)] [RED("playSFXOnActivate")] 		public CName PlaySFXOnActivate { get; set;}

		[Ordinal(0)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(0)] [RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[Ordinal(0)] [RED("disableAgony")] 		public CBool DisableAgony { get; set;}

		[Ordinal(0)] [RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(0)] [RED("disableCollisionDelay")] 		public CFloat DisableCollisionDelay { get; set;}

		[Ordinal(0)] [RED("disableCollisionOnAnim")] 		public CBool DisableCollisionOnAnim { get; set;}

		[Ordinal(0)] [RED("disableCollisionOnAnimDelay")] 		public CFloat DisableCollisionOnAnimDelay { get; set;}

		[Ordinal(0)] [RED("destroyAfterAnimDelay")] 		public CFloat DestroyAfterAnimDelay { get; set;}

		[Ordinal(0)] [RED("disableRagdollAfter")] 		public CFloat DisableRagdollAfter { get; set;}

		public CAINpcDeathParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcDeathParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}