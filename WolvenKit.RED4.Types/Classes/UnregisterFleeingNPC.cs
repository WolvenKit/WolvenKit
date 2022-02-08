using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterFleeingNPC : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("runner")] 
		public CWeakHandle<entEntity> Runner
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}
	}
}
