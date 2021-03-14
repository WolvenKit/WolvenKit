using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCCOpCustomizeInventory : ICharacterCustomizationOperation
	{
		[Ordinal(1)] [RED("template")] 		public CHandle<CEntityTemplate> Template { get; set;}

		[Ordinal(2)] [RED("applyMounts")] 		public CBool ApplyMounts { get; set;}

		public CCCOpCustomizeInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCCOpCustomizeInventory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}