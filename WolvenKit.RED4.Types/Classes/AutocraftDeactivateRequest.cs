using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutocraftDeactivateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("resetMemory")] 
		public CBool ResetMemory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
