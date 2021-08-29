using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scriptOptimizationsHandleWithValue : RedBaseClass
	{
		private CFloat _value;
		private CHandle<IScriptable> _handle;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("handle")] 
		public CHandle<IScriptable> Handle
		{
			get => GetProperty(ref _handle);
			set => SetProperty(ref _handle, value);
		}
	}
}
