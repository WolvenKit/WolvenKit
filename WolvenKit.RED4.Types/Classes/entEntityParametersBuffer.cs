using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityParametersBuffer : RedBaseClass
	{
		private CArray<SerializationDeferredDataBuffer> _parameterBuffers;

		[Ordinal(0)] 
		[RED("parameterBuffers")] 
		public CArray<SerializationDeferredDataBuffer> ParameterBuffers
		{
			get => GetProperty(ref _parameterBuffers);
			set => SetProperty(ref _parameterBuffers, value);
		}
	}
}
