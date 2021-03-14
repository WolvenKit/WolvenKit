using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTSaveNamedTargetOnEventDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("namedTargetToSave")] 		public CName NamedTargetToSave { get; set;}

		[Ordinal(2)] [RED("saveUnder")] 		public CBehTreeValCName SaveUnder { get; set;}

		[Ordinal(3)] [RED("gameplayEventToSaveOn")] 		public CBehTreeValCName GameplayEventToSaveOn { get; set;}

		public BTSaveNamedTargetOnEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTSaveNamedTargetOnEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}