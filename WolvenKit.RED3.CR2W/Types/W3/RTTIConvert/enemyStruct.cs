using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class enemyStruct : CVariable
	{
		[Ordinal(1)] [RED("enemyType")] 		public CEnum<EMonsterCategory> EnemyType { get; set;}

		[Ordinal(2)] [RED("enemyCount")] 		public CInt32 EnemyCount { get; set;}

		[Ordinal(3)] [RED("enemyName")] 		public CName EnemyName { get; set;}

		public enemyStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new enemyStruct(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}