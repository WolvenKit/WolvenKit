using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class enteventsHitCharacterControllerEvent : redEvent
	{
		private CWeakHandle<entEntity> _entity;
		private CWeakHandle<entIComponent> _component;

		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("component")] 
		public CWeakHandle<entIComponent> Component
		{
			get => GetProperty(ref _component);
			set => SetProperty(ref _component, value);
		}
	}
}
