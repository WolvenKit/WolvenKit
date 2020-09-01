using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEntityAppearance : CVariable
	{
		[Ordinal(0)] [RED("("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("("voicetag")] 		public CName Voicetag { get; set;}

		[Ordinal(0)] [RED("("appearanceParams", 2,0)] 		public CArray<CPtr<CEntityTemplateParam>> AppearanceParams { get; set;}

		[Ordinal(0)] [RED("("useVertexCollapse")] 		public CBool UseVertexCollapse { get; set;}

		[Ordinal(0)] [RED("("usesRobe")] 		public CBool UsesRobe { get; set;}

		[Ordinal(0)] [RED("("wasIncluded")] 		public CBool WasIncluded { get; set;}

		[Ordinal(0)] [RED("("includedTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> IncludedTemplates { get; set;}

		[Ordinal(0)] [RED("("collapsedComponents", 2,0)] 		public CArray<CName> CollapsedComponents { get; set;}

		public CEntityAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntityAppearance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}