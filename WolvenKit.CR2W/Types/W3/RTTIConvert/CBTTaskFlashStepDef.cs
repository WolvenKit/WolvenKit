using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlashStepDef : IBehTreeTaskDefinition
	{
		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[RED("teleportType")] 		public ETeleportType TeleportType { get; set;}

		[RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[RED("appearFXName")] 		public CName AppearFXName { get; set;}

		public CBTTaskFlashStepDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskFlashStepDef(cr2w);

	}
}