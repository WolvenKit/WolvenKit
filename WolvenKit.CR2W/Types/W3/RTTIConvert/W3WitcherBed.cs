using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WitcherBed : W3AnimationInteractionEntity
	{
		[RED("m_wasUsed")] 		public CBool M_wasUsed { get; set;}

		[RED("m_wereItemsRefilled")] 		public CBool M_wereItemsRefilled { get; set;}

		[RED("m_bedSaveLock")] 		public CInt32 M_bedSaveLock { get; set;}

		[RED("m_bedLevel")] 		public CInt32 M_bedLevel { get; set;}

		[RED("m_handsIkActive")] 		public CBool M_handsIkActive { get; set;}

		public W3WitcherBed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WitcherBed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}