using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HidePuppetDelayEvent : redEvent
	{
		private CWeakHandle<NPCPuppet> _target;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<NPCPuppet> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
