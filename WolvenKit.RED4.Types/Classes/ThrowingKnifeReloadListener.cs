using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThrowingKnifeReloadListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("knife")] 
		public CWeakHandle<Knife> Knife
		{
			get => GetPropertyValue<CWeakHandle<Knife>>();
			set => SetPropertyValue<CWeakHandle<Knife>>(value);
		}
	}
}
