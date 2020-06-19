using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCardDefinition : CVariable
	{
		[RED("index")] 		public CInt32 Index { get; set;}

		[RED("title")] 		public CString Title { get; set;}

		[RED("description")] 		public CString Description { get; set;}

		[RED("power")] 		public CInt32 Power { get; set;}

		[RED("picture")] 		public CString Picture { get; set;}

		[RED("faction")] 		public CEnum<eGwintFaction> Faction { get; set;}

		[RED("typeFlags")] 		public CInt32 TypeFlags { get; set;}

		[RED("effectFlags", 2,0)] 		public CArray<CEnum<eGwintEffect>> EffectFlags { get; set;}

		[RED("summonFlags", 2,0)] 		public CArray<CInt32> SummonFlags { get; set;}

		[RED("dlcPictureFlag")] 		public CName DlcPictureFlag { get; set;}

		[RED("dlcPicture")] 		public CString DlcPicture { get; set;}

		public SCardDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCardDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}