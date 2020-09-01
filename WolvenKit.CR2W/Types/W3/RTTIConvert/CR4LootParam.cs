using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LootParam : CGameplayEntityParam
	{
		[Ordinal(0)] [RED("("containers", 2,0)] 		public CArray<CR4LootContainerParam> Containers { get; set;}

		[Ordinal(0)] [RED("("usedContainersMin")] 		public CUInt32 UsedContainersMin { get; set;}

		[Ordinal(0)] [RED("("usedContainersMax")] 		public CUInt32 UsedContainersMax { get; set;}

		[Ordinal(0)] [RED("("alwaysPresent")] 		public CBool AlwaysPresent { get; set;}

		public CR4LootParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LootParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}