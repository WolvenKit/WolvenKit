using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputContextSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("activeContext")] 
		public CEnum<inputContextType> ActiveContext
		{
			get => GetPropertyValue<CEnum<inputContextType>>();
			set => SetPropertyValue<CEnum<inputContextType>>(value);
		}
	}
}
