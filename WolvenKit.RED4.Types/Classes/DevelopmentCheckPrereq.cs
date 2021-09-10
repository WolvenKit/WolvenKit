using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("requiredLevel")] 
		public CFloat RequiredLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
