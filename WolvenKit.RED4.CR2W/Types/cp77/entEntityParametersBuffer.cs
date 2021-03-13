using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersBuffer : CVariable
	{
		[Ordinal(0)] [RED("parameterBuffers")] public CArray<serializationDeferredDataBuffer> ParameterBuffers { get; set; }

		public entEntityParametersBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
