using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityParametersBuffer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parameterBuffers")] 
		public CArray<SerializationDeferredDataBuffer> ParameterBuffers
		{
			get => GetPropertyValue<CArray<SerializationDeferredDataBuffer>>();
			set => SetPropertyValue<CArray<SerializationDeferredDataBuffer>>(value);
		}

		public entEntityParametersBuffer()
		{
			ParameterBuffers = new();
		}
	}
}
