using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReevaluateDetectionOverwriteEvent : redEvent
	{
		private CWeakHandle<entEntity> _target;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<entEntity> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
