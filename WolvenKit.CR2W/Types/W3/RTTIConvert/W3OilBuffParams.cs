using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3OilBuffParams : W3BuffCustomParams
	{
		[RED("iconPath")] 		public CString IconPath { get; set;}

		[RED("localizedName")] 		public CString LocalizedName { get; set;}

		[RED("localizedDescription")] 		public CString LocalizedDescription { get; set;}

		[RED("currCount")] 		public CInt32 CurrCount { get; set;}

		[RED("maxCount")] 		public CInt32 MaxCount { get; set;}

		[RED("sword")] 		public SItemUniqueId Sword { get; set;}

		[RED("oilAbilityName")] 		public CName OilAbilityName { get; set;}

		[RED("oilItemName")] 		public CName OilItemName { get; set;}

		public W3OilBuffParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3OilBuffParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}