using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MappinsDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(1)] [RED("worldFilePath")] 		public CSoft<CWorld> WorldFilePath { get; set;}

		[Ordinal(2)] [RED("mappinsFilePath")] 		public CSoft<CEntityMapPinsResource> MappinsFilePath { get; set;}

		[Ordinal(3)] [RED("questMappinsFilePath")] 		public CSoft<CQuestMapPinsResource> QuestMappinsFilePath { get; set;}

		public CR4MappinsDLCMounter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MappinsDLCMounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}