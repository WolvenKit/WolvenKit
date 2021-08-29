using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetAcquiredEvent : redEvent
	{
		private CWeakHandle<ScriptedPuppet> _target;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<ScriptedPuppet> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
