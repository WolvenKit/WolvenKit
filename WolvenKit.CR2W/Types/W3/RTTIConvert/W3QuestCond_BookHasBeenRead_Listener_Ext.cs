using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_BookHasBeenRead_Listener_Ext : IGlobalEventScriptedListener
	{
		[Ordinal(1)] [RED("("condition")] 		public CHandle<W3QuestCond_BookHasBeenReadExt> Condition { get; set;}

		public W3QuestCond_BookHasBeenRead_Listener_Ext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_BookHasBeenRead_Listener_Ext(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}