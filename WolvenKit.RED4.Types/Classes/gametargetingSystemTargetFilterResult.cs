using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametargetingSystemTargetFilterResult : IScriptable
	{
		private entEntityID _hitEntId;
		private CWeakHandle<entIComponent> _hitComponent;

		[Ordinal(0)] 
		[RED("hitEntId")] 
		public entEntityID HitEntId
		{
			get => GetProperty(ref _hitEntId);
			set => SetProperty(ref _hitEntId, value);
		}

		[Ordinal(1)] 
		[RED("hitComponent")] 
		public CWeakHandle<entIComponent> HitComponent
		{
			get => GetProperty(ref _hitComponent);
			set => SetProperty(ref _hitComponent, value);
		}
	}
}
