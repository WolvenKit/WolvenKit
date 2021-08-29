using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SPreventionAgentData : IScriptable
	{
		private CWeakHandle<gamePersistentState> _ps;

		[Ordinal(0)] 
		[RED("ps")] 
		public CWeakHandle<gamePersistentState> Ps
		{
			get => GetProperty(ref _ps);
			set => SetProperty(ref _ps, value);
		}
	}
}
