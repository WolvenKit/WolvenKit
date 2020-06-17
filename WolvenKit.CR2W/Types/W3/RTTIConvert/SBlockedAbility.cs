using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBlockedAbility : CVariable
	{
		[RED("abilityName")] 		public CName AbilityName { get; set;}

		[RED("timeWhenEnabledd")] 		public CFloat TimeWhenEnabledd { get; set;}

		[RED("count")] 		public CInt32 Count { get; set;}

		public SBlockedAbility(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBlockedAbility(cr2w);

	}
}