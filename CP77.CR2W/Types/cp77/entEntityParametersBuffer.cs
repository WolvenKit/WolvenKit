using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersBuffer : CVariable
	{
		[Ordinal(0)]  [RED("parameterBuffers")] public CArray<serializationDeferredDataBuffer> ParameterBuffers { get; set; }

		public entEntityParametersBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
