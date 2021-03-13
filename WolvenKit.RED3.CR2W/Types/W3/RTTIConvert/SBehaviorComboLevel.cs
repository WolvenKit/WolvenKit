using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorComboLevel : CVariable
	{
		[Ordinal(1)] [RED("dirFront")] 		public SBehaviorComboDirection DirFront { get; set;}

		[Ordinal(2)] [RED("dirBack")] 		public SBehaviorComboDirection DirBack { get; set;}

		[Ordinal(3)] [RED("dirLeft")] 		public SBehaviorComboDirection DirLeft { get; set;}

		[Ordinal(4)] [RED("dirRight")] 		public SBehaviorComboDirection DirRight { get; set;}

		[Ordinal(5)] [RED("abilityRequired")] 		public CName AbilityRequired { get; set;}

		public SBehaviorComboLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorComboLevel(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}