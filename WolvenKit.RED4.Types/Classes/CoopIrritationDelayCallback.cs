using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CoopIrritationDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CWeakHandle<gameObject> _companion;

		[Ordinal(0)] 
		[RED("companion")] 
		public CWeakHandle<gameObject> Companion
		{
			get => GetProperty(ref _companion);
			set => SetProperty(ref _companion, value);
		}
	}
}
