using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BreachViewTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)] 
		[RED("myOwner")] 
		public CWeakHandle<gameObject> MyOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
