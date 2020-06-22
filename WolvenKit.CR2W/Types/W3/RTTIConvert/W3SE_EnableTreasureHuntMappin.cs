using System.IO;
using System.Runtime.Serialization;
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

		[RED("mappinEntity")] 		public CHandle<W3TreasureHuntMappinEntity> MappinEntity { get; set;}

		[RED("commonMapManager")] 		public CHandle<CCommonMapManager> CommonMapManager { get; set;}

		public W3SE_EnableTreasureHuntMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SE_EnableTreasureHuntMappin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}