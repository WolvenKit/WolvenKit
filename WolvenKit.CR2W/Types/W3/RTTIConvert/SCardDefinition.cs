using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCardDefinition : CVariable
	{
		[Ordinal(1)] [RED("index")] 		public CInt32 Index { get; set;}

		[Ordinal(2)] [RED("title")] 		public CString Title { get; set;}

		[Ordinal(3)] [RED("description")] 		public CString Description { get; set;}

		[Ordinal(4)] [RED("power")] 		public CInt32 Power { get; set;}

		[Ordinal(5)] [RED("picture")] 		public CString Picture { get; set;}

		[Ordinal(6)] [RED("faction")] 		public CEnum<eGwintFaction> Faction { get; set;}

		[Ordinal(7)] [RED("typeFlags")] 		public CInt32 TypeFlags { get; set;}

		[Ordinal(8)] [RED("effectFlags", 2,0)] 		public CArray<CEnum<eGwintEffect>> EffectFlags { get; set;}

		[Ordinal(9)] [RED("summonFlags", 2,0)] 		public CArray<CInt32> SummonFlags { get; set;}

		[Ordinal(10)] [RED("dlcPictureFlag")] 		public CName DlcPictureFlag { get; set;}

		[Ordinal(11)] [RED("dlcPicture")] 		public CString DlcPicture { get; set;}

		public SCardDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCardDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}