using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskCompleteOnGameplayEventDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("gameplayEvent")] 		public CName GameplayEvent { get; set;}

		[Ordinal(2)] [RED("sucess")] 		public CBool Sucess { get; set;}

		public BTTaskCompleteOnGameplayEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskCompleteOnGameplayEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}