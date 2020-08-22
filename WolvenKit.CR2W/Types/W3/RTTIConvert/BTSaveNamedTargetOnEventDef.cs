using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTSaveNamedTargetOnEventDef : IBehTreeTaskDefinition
	{
		[RED("namedTargetToSave")] 		public CName NamedTargetToSave { get; set;}

		[RED("saveUnder")] 		public CBehTreeValCName SaveUnder { get; set;}

		[RED("gameplayEventToSaveOn")] 		public CBehTreeValCName GameplayEventToSaveOn { get; set;}

		public BTSaveNamedTargetOnEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTSaveNamedTargetOnEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}