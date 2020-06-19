using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CComboString : CObject
	{
		[RED("attacks", 2,0)] 		public CArray<SComboAnimationData> Attacks { get; set;}

		[RED("distAttacks", 2,0)] 		public CArray<CArray<SComboAnimationData>> DistAttacks { get; set;}

		[RED("dirAttacks", 2,0)] 		public CArray<CArray<CArray<SComboAnimationData>>> DirAttacks { get; set;}

		[RED("leftSide")] 		public CBool LeftSide { get; set;}

		public CComboString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CComboString(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}