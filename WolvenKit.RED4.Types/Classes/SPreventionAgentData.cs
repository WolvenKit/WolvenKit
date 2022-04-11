using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SPreventionAgentData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ps")] 
		public CWeakHandle<gamePersistentState> Ps
		{
			get => GetPropertyValue<CWeakHandle<gamePersistentState>>();
			set => SetPropertyValue<CWeakHandle<gamePersistentState>>(value);
		}
	}
}
