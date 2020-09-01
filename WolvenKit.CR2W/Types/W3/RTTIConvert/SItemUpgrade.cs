using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemUpgrade : CVariable
	{
		[Ordinal(0)] [RED("("upgradeName")] 		public CName UpgradeName { get; set;}

		[Ordinal(0)] [RED("("localizedName")] 		public CName LocalizedName { get; set;}

		[Ordinal(0)] [RED("("localizedDescriptionName")] 		public CName LocalizedDescriptionName { get; set;}

		[Ordinal(0)] [RED("("cost")] 		public CInt32 Cost { get; set;}

		[Ordinal(0)] [RED("("iconPath")] 		public CString IconPath { get; set;}

		[Ordinal(0)] [RED("("ability")] 		public CName Ability { get; set;}

		[Ordinal(0)] [RED("("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[Ordinal(0)] [RED("("requiredUpgrades", 2,0)] 		public CArray<CName> RequiredUpgrades { get; set;}

		public SItemUpgrade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SItemUpgrade(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}