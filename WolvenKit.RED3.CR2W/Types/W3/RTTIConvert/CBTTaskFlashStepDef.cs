using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlashStepDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(4)] [RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[Ordinal(5)] [RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[Ordinal(6)] [RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(7)] [RED("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[Ordinal(8)] [RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(9)] [RED("appearFXName")] 		public CName AppearFXName { get; set;}

		public CBTTaskFlashStepDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}