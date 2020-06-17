using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDespawnDef : IBehTreeTaskDefinition
	{
		[RED("despawnEventName")] 		public CName DespawnEventName { get; set;}

		[RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("destroyCooldown")] 		public CFloat DestroyCooldown { get; set;}

		public CBTTaskDespawnDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskDespawnDef(cr2w);

	}
}