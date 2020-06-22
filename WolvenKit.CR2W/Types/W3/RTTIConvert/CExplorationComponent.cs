using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationComponent : CComponent
	{
		[RED("explorationId")] 		public CEnum<EExplorationType> ExplorationId { get; set;}

		[RED("start")] 		public Vector Start { get; set;}

		[RED("end")] 		public Vector End { get; set;}

		[RED("componentForEvents")] 		public CString ComponentForEvents { get; set;}

		[RED("internalExploration")] 		public CBool InternalExploration { get; set;}

		public CExplorationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}