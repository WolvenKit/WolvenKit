using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleTimeListener : tickScriptTimeDilationListener
	{
		private CWeakHandle<sampleTimeDilatable> _myOwner;

		[Ordinal(0)] 
		[RED("myOwner")] 
		public CWeakHandle<sampleTimeDilatable> MyOwner
		{
			get => GetProperty(ref _myOwner);
			set => SetProperty(ref _myOwner, value);
		}
	}
}
