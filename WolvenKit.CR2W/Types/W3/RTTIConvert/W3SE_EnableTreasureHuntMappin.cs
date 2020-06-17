using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_EnableTreasureHuntMappin : W3SwitchEvent
	{
		[RED("mappinEntityTag")] 		public CName MappinEntityTag { get; set;}

		[RED("enable")] 		public CBool Enable { get; set;}

		public W3SE_EnableTreasureHuntMappin(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SE_EnableTreasureHuntMappin(cr2w);

	}
}