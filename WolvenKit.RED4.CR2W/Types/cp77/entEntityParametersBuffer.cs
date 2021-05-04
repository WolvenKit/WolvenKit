using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersBuffer : CVariable
	{
		private CArray<serializationDeferredDataBuffer> _parameterBuffers;

		[Ordinal(0)] 
		[RED("parameterBuffers")] 
		public CArray<serializationDeferredDataBuffer> ParameterBuffers
		{
			get => GetProperty(ref _parameterBuffers);
			set => SetProperty(ref _parameterBuffers, value);
		}

		public entEntityParametersBuffer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
