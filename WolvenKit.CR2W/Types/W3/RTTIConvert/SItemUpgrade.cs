using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemUpgrade : CVariable
	{
		[RED("upgradeName")] 		public CName UpgradeName { get; set;}

		[RED("localizedName")] 		public CName LocalizedName { get; set;}

		[RED("localizedDescriptionName")] 		public CName LocalizedDescriptionName { get; set;}

		[RED("cost")] 		public CInt32 Cost { get; set;}

		[RED("iconPath")] 		public CString IconPath { get; set;}

		[RED("ability")] 		public CName Ability { get; set;}

		[RED("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[RED("requiredUpgrades", 2,0)] 		public CArray<CName> RequiredUpgrades { get; set;}

		public SItemUpgrade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SItemUpgrade(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}