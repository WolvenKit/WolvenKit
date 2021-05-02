using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SRequiredSwitch : CVariable
	{
		[Ordinal(1)] [RED("requiredSwitchTag")] 		public CName RequiredSwitchTag { get; set;}

		[Ordinal(2)] [RED("switchState")] 		public CEnum<ERequiredSwitchState> SwitchState { get; set;}

		public SRequiredSwitch(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SRequiredSwitch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}