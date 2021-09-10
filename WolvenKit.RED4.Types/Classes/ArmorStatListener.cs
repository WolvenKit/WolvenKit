using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArmorStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}
	}
}
