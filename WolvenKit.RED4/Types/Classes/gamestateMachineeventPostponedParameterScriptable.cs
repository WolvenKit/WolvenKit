using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventPostponedParameterScriptable : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CHandle<IScriptable> Value
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public gamestateMachineeventPostponedParameterScriptable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
