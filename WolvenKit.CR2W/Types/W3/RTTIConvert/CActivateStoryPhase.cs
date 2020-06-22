using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActivateStoryPhase : IQuestSpawnsetAction
	{
		[RED("spawnset")] 		public CSoft<CCommunity> Spawnset { get; set;}

		[RED("phase")] 		public CName Phase { get; set;}

		[RED("streamingPartition")] 		public CString StreamingPartition { get; set;}

		public CActivateStoryPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActivateStoryPhase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}