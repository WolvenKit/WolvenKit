using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineparameterTypeItemEquipRequest : IScriptable
	{
		private TweakDBID _slotId;
		private gameItemID _itemId;
		private CEnum<ERenderingPlane> _startingRenderingPlane;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(2)] 
		[RED("startingRenderingPlane")] 
		public CEnum<ERenderingPlane> StartingRenderingPlane
		{
			get => GetProperty(ref _startingRenderingPlane);
			set => SetProperty(ref _startingRenderingPlane, value);
		}
	}
}
