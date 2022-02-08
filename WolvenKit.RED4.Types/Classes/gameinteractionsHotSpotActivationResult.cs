using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsHotSpotActivationResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
