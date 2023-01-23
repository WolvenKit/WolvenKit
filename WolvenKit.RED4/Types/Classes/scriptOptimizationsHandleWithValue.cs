using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scriptOptimizationsHandleWithValue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("handle")] 
		public CHandle<IScriptable> Handle
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public scriptOptimizationsHandleWithValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
