using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BreachViewTimeListener : tickScriptTimeDilationListener
	{
		private CWeakHandle<gameObject> _myOwner;

		[Ordinal(0)] 
		[RED("myOwner")] 
		public CWeakHandle<gameObject> MyOwner
		{
			get => GetProperty(ref _myOwner);
			set => SetProperty(ref _myOwner, value);
		}
	}
}
