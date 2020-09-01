using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDeckDefinition : CVariable
	{
		[Ordinal(0)] [RED("("cardIndices", 2,0)] 		public CArray<CInt32> CardIndices { get; set;}

		[Ordinal(0)] [RED("("leaderIndex")] 		public CInt32 LeaderIndex { get; set;}

		[Ordinal(0)] [RED("("unlocked")] 		public CBool Unlocked { get; set;}

		[Ordinal(0)] [RED("("specialCard")] 		public CInt32 SpecialCard { get; set;}

		[Ordinal(0)] [RED("("dynamicCardRequirements", 2,0)] 		public CArray<CInt32> DynamicCardRequirements { get; set;}

		[Ordinal(0)] [RED("("dynamicCards", 2,0)] 		public CArray<CInt32> DynamicCards { get; set;}

		public SDeckDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDeckDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}