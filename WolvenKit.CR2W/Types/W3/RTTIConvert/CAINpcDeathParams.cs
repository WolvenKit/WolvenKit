using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcDeathParams : CAIDeathParameters
	{
		[RED("createReactionEvent")] 		public CName CreateReactionEvent { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("playFXOnActivate")] 		public CName PlayFXOnActivate { get; set;}

		[RED("playFXOnDeactivate")] 		public CName PlayFXOnDeactivate { get; set;}

		[RED("stopFXOnActivate")] 		public CName StopFXOnActivate { get; set;}

		[RED("stopFXOnDeactivate")] 		public CName StopFXOnDeactivate { get; set;}

		[RED("playSFXOnActivate")] 		public CName PlaySFXOnActivate { get; set;}

		[RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[RED("disableAgony")] 		public CBool DisableAgony { get; set;}

		[RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[RED("disableCollisionDelay")] 		public CFloat DisableCollisionDelay { get; set;}

		[RED("disableCollisionOnAnim")] 		public CBool DisableCollisionOnAnim { get; set;}

		[RED("disableCollisionOnAnimDelay")] 		public CFloat DisableCollisionOnAnimDelay { get; set;}

		[RED("destroyAfterAnimDelay")] 		public CFloat DestroyAfterAnimDelay { get; set;}

		[RED("disableRagdollAfter")] 		public CFloat DisableRagdollAfter { get; set;}

		public CAINpcDeathParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAINpcDeathParams(cr2w);

	}
}