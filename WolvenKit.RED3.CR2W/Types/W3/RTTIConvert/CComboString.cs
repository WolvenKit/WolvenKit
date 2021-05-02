using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CComboString : CObject
	{
		[Ordinal(1)] [RED("attacks", 2,0)] 		public CArray<SComboAnimationData> Attacks { get; set;}

		[Ordinal(2)] [RED("distAttacks", 2,0)] 		public CArray<CArray<SComboAnimationData>> DistAttacks { get; set;}

		[Ordinal(3)] [RED("dirAttacks", 2,0)] 		public CArray<CArray<CArray<SComboAnimationData>>> DirAttacks { get; set;}

		[Ordinal(4)] [RED("leftSide")] 		public CBool LeftSide { get; set;}

		public CComboString(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}