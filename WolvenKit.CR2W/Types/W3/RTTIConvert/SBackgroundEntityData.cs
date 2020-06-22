using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBackgroundEntityData : CVariable
	{
		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("spawnSlotName")] 		public CName SpawnSlotName { get; set;}

		[RED("workAnimationEvent")] 		public CEnum<EBackgroundNPCWork_Single> WorkAnimationEvent { get; set;}

		[RED("appearanceName")] 		public CName AppearanceName { get; set;}

		public SBackgroundEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBackgroundEntityData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}