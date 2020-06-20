using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorComboLevel : CVariable
	{
		[RED("dirFront")] 		public SBehaviorComboDirection DirFront { get; set;}

		[RED("dirBack")] 		public SBehaviorComboDirection DirBack { get; set;}

		[RED("dirLeft")] 		public SBehaviorComboDirection DirLeft { get; set;}

		[RED("dirRight")] 		public SBehaviorComboDirection DirRight { get; set;}

		[RED("abilityRequired")] 		public CName AbilityRequired { get; set;}

		public SBehaviorComboLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorComboLevel(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}