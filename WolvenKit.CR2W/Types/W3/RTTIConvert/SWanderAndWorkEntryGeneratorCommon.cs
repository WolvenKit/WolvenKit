using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWanderAndWorkEntryGeneratorCommon : CVariable
	{
		[RED("wanderParams")] 		public CHandle<CAINpcHistoryWanderParams> WanderParams { get; set;}

		[RED("spawnToWork")] 		public CBool SpawnToWork { get; set;}

		[RED("delay")] 		public CFloat Delay { get; set;}

		public SWanderAndWorkEntryGeneratorCommon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWanderAndWorkEntryGeneratorCommon(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}