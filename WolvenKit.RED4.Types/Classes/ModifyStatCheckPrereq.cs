using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyStatCheckPrereq : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("statCheckState")] 
		public CHandle<StatCheckPrereqState> StatCheckState
		{
			get => GetPropertyValue<CHandle<StatCheckPrereqState>>();
			set => SetPropertyValue<CHandle<StatCheckPrereqState>>(value);
		}
	}
}
