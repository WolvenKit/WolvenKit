using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SRecordedInput : CVariable
	{
		public SRecordedInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SRecordedInput(cr2w, parent, name);

	}
}