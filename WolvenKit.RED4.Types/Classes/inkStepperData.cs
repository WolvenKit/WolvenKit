using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStepperData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CWeakHandle<IScriptable> Data
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		public inkStepperData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
