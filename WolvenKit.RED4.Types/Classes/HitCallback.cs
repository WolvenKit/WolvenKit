using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitCallback : gameScriptedDamageSystemListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<GenericHitPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<GenericHitPrereqState>>();
			set => SetPropertyValue<CWeakHandle<GenericHitPrereqState>>(value);
		}
	}
}
