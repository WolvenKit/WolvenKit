using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		private CFloat _requiredLevel;

		[Ordinal(0)] 
		[RED("requiredLevel")] 
		public CFloat RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}
	}
}
