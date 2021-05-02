using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;

namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IAnalyzer : CVariable
	{
		public IAnalyzer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		
	}
}