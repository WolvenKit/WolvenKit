using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3YrdenEntity : W3SignEntity
	{
		[RED("effects", 2,0)] 		public CArray<SYrdenEffects> Effects { get; set;}

		[RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[RED("projDestroyFxEntTemplate")] 		public CHandle<CEntityTemplate> ProjDestroyFxEntTemplate { get; set;}

		[RED("runeTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> RuneTemplates { get; set;}

		public W3YrdenEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3YrdenEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}