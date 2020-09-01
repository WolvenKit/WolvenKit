using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3OilBuffParams : W3BuffCustomParams
	{
		[Ordinal(1)] [RED("iconPath")] 		public CString IconPath { get; set;}

		[Ordinal(2)] [RED("localizedName")] 		public CString LocalizedName { get; set;}

		[Ordinal(3)] [RED("localizedDescription")] 		public CString LocalizedDescription { get; set;}

		[Ordinal(4)] [RED("currCount")] 		public CInt32 CurrCount { get; set;}

		[Ordinal(5)] [RED("maxCount")] 		public CInt32 MaxCount { get; set;}

		[Ordinal(6)] [RED("sword")] 		public SItemUniqueId Sword { get; set;}

		[Ordinal(7)] [RED("oilAbilityName")] 		public CName OilAbilityName { get; set;}

		[Ordinal(8)] [RED("oilItemName")] 		public CName OilItemName { get; set;}

		public W3OilBuffParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3OilBuffParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}