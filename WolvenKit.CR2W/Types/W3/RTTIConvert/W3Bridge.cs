using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Bridge : W3DestroyableTerrain
	{
		[RED("m_currentFxID")] 		public CInt32 M_currentFxID { get; set;}

		[RED("entryTime")] 		public CFloat EntryTime { get; set;}

		[RED("timerInterval")] 		public CFloat TimerInterval { get; set;}

		[RED("rot")] 		public EulerAngles Rot { get; set;}

		public W3Bridge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Bridge(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}