using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeActiveContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<inputContextType> NewContext
		{
			get => GetPropertyValue<CEnum<inputContextType>>();
			set => SetPropertyValue<CEnum<inputContextType>>(value);
		}
	}
}
