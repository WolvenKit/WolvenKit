using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathAnimDecoratorDef : IBehTreeTaskDefinition
	{
		[RED("completeTimer")] 		public CFloat CompleteTimer { get; set;}

		[RED("disableCollisionOnAnim")] 		public CBehTreeValBool DisableCollisionOnAnim { get; set;}

		[RED("disableCollisionOnAnimDelay")] 		public CBehTreeValFloat DisableCollisionOnAnimDelay { get; set;}

		[RED("stopFXOnActivate")] 		public CBehTreeValCName StopFXOnActivate { get; set;}

		[RED("stopFXOnDeactivate")] 		public CBehTreeValCName StopFXOnDeactivate { get; set;}

		[RED("playFXOnActivate")] 		public CBehTreeValCName PlayFXOnActivate { get; set;}

		[RED("playFXOnDeactivate")] 		public CBehTreeValCName PlayFXOnDeactivate { get; set;}

		[RED("playSFXOnActivate")] 		public CBehTreeValCName PlaySFXOnActivate { get; set;}

		public CBehTreeTaskDeathAnimDecoratorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathAnimDecoratorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}