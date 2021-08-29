using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeActiveContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<inputContextType> _newContext;

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<inputContextType> NewContext
		{
			get => GetProperty(ref _newContext);
			set => SetProperty(ref _newContext, value);
		}
	}
}
