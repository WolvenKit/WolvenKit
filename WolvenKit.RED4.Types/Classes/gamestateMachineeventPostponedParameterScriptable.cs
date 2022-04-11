using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventPostponedParameterScriptable : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CHandle<IScriptable> Value
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}
	}
}
