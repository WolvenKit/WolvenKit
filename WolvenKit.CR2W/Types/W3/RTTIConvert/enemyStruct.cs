using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class enemyStruct : CVariable
	{
		[RED("enemyType")] 		public CEnum<EMonsterCategory> EnemyType { get; set;}

		[RED("enemyCount")] 		public CInt32 EnemyCount { get; set;}

		[RED("enemyName")] 		public CName EnemyName { get; set;}

		public enemyStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new enemyStruct(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}