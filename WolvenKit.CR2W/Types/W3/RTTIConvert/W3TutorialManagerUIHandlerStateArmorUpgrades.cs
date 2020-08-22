using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateArmorUpgrades : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("TAB")] 		public CName TAB { get; set;}

		[RED("UPGRADE")] 		public CName UPGRADE { get; set;}

		[RED("ITEM")] 		public CName ITEM { get; set;}

		public W3TutorialManagerUIHandlerStateArmorUpgrades(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateArmorUpgrades(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}