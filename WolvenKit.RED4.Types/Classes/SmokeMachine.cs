using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmokeMachine : BasicDistractionDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CBool _highLightActive;
		private CArray<CWeakHandle<entEntity>> _entities;

		[Ordinal(103)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(104)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetProperty(ref _highLightActive);
			set => SetProperty(ref _highLightActive, value);
		}

		[Ordinal(105)] 
		[RED("entities")] 
		public CArray<CWeakHandle<entEntity>> Entities
		{
			get => GetProperty(ref _entities);
			set => SetProperty(ref _entities, value);
		}
	}
}
