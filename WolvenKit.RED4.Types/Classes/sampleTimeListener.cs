using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)] 
		[RED("myOwner")] 
		public CWeakHandle<sampleTimeDilatable> MyOwner
		{
			get => GetPropertyValue<CWeakHandle<sampleTimeDilatable>>();
			set => SetPropertyValue<CWeakHandle<sampleTimeDilatable>>(value);
		}
	}
}
