using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDespawnDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("callFromQuest")] 		public CBool CallFromQuest { get; set;}

		[Ordinal(2)] [RED("despawnEventName")] 		public CName DespawnEventName { get; set;}

		[Ordinal(3)] [RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(4)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(5)] [RED("destroyCooldown")] 		public CFloat DestroyCooldown { get; set;}

		public CBTTaskDespawnDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDespawnDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}