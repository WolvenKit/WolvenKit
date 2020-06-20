using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDefendDef : IBehTreeTaskDefinition
	{
		[RED("useCustomHits")] 		public CBool UseCustomHits { get; set;}

		[RED("listenToParryEvents")] 		public CBool ListenToParryEvents { get; set;}

		[RED("completeTaskOnIsDefending")] 		public CBool CompleteTaskOnIsDefending { get; set;}

		[RED("minimumDuration")] 		public CFloat MinimumDuration { get; set;}

		[RED("playParrySound")] 		public CBool PlayParrySound { get; set;}

		public CBTTaskDefendDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDefendDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}