using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDeckDefinition : CVariable
	{
		[Ordinal(1)] [RED("cardIndices", 2,0)] 		public CArray<CInt32> CardIndices { get; set;}

		[Ordinal(2)] [RED("leaderIndex")] 		public CInt32 LeaderIndex { get; set;}

		[Ordinal(3)] [RED("unlocked")] 		public CBool Unlocked { get; set;}

		[Ordinal(4)] [RED("specialCard")] 		public CInt32 SpecialCard { get; set;}

		[Ordinal(5)] [RED("dynamicCardRequirements", 2,0)] 		public CArray<CInt32> DynamicCardRequirements { get; set;}

		[Ordinal(6)] [RED("dynamicCards", 2,0)] 		public CArray<CInt32> DynamicCards { get; set;}

		public SDeckDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDeckDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}