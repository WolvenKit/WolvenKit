using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GameZoneTrigger : CEntity
	{
		[Ordinal(1)] [RED("playerEntity")] 		public CHandle<CPlayer> PlayerEntity { get; set;}

		[Ordinal(2)] [RED("zoneName")] 		public CName ZoneName { get; set;}

		public W3GameZoneTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GameZoneTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}