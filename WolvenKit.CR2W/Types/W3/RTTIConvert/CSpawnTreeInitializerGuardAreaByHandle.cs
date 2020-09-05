using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeInitializerGuardAreaByHandle : ISpawnTreeInitializerGuardAreaBase
	{
		[Ordinal(1)] [RED("guardArea")] 		public EntityHandle GuardArea { get; set;}

		[Ordinal(2)] [RED("pursuitArea")] 		public EntityHandle PursuitArea { get; set;}

		public CSpawnTreeInitializerGuardAreaByHandle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeInitializerGuardAreaByHandle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}