using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamehitRepresentationEventsToggleHitShapeEvent : redEvent
	{
		private CBool _enable;
		private CName _hitShapeName;
		private CBool _hierarchical;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get => GetProperty(ref _hitShapeName);
			set => SetProperty(ref _hitShapeName, value);
		}

		[Ordinal(2)] 
		[RED("hierarchical")] 
		public CBool Hierarchical
		{
			get => GetProperty(ref _hierarchical);
			set => SetProperty(ref _hierarchical, value);
		}
	}
}
