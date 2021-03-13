using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTSaveNamedTargetOnEvent : IBehTreeTask
	{
		[Ordinal(1)] [RED("namedTargetToSave")] 		public CName NamedTargetToSave { get; set;}

		[Ordinal(2)] [RED("saveUnder")] 		public CName SaveUnder { get; set;}

		[Ordinal(3)] [RED("gameplayEventToSaveOn")] 		public CName GameplayEventToSaveOn { get; set;}

		public BTSaveNamedTargetOnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTSaveNamedTargetOnEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}