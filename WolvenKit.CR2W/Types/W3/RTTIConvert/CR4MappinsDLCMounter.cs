using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MappinsDLCMounter : IGameplayDLCMounter
	{
		[RED("worldFilePath")] 		public CSoft<CWorld> WorldFilePath { get; set;}

		[RED("mappinsFilePath")] 		public CSoft<CEntityMapPinsResource> MappinsFilePath { get; set;}

		[RED("questMappinsFilePath")] 		public CSoft<CQuestMapPinsResource> QuestMappinsFilePath { get; set;}

		public CR4MappinsDLCMounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MappinsDLCMounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}