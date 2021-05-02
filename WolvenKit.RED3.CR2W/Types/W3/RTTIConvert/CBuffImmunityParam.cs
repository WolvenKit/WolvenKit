using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBuffImmunityParam : CGameplayEntityParam
	{
		[Ordinal(1)] [RED("immunityTo", 2,0)] 		public CArray<CInt32> ImmunityTo { get; set;}

		[Ordinal(2)] [RED("flags")] 		public CEnum<EImmunityFlags> Flags { get; set;}

		public CBuffImmunityParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}