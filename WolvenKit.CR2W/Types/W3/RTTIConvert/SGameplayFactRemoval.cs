using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayFactRemoval : CVariable
	{
		[Ordinal(1)] [RED("("factName")] 		public CString FactName { get; set;}

		[Ordinal(2)] [RED("("value")] 		public CInt32 Value { get; set;}

		[Ordinal(3)] [RED("("timerID")] 		public CInt32 TimerID { get; set;}

		public SGameplayFactRemoval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayFactRemoval(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}