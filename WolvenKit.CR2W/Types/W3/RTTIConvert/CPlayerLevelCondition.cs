using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayerLevelCondition : ISpawnCondition
	{
		[RED("minLevel")] 		public CInt32 MinLevel { get; set;}

		[RED("maxLevel")] 		public CInt32 MaxLevel { get; set;}

		public CPlayerLevelCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CPlayerLevelCondition(cr2w);

	}
}