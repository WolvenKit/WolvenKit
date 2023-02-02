using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateMachineInstanceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("referenceName")] 
		public CName ReferenceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("initData")] 
		public CHandle<IScriptable> InitData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public gamestateMachineStateMachineInstanceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
