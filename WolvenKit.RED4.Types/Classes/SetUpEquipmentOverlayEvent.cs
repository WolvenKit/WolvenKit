using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetUpEquipmentOverlayEvent : redEvent
	{
		private CName _meshOverlayEffectName;
		private CName _meshOverlayEffectTag;
		private CArray<TweakDBID> _meshOverlaySlots;

		[Ordinal(0)] 
		[RED("meshOverlayEffectName")] 
		public CName MeshOverlayEffectName
		{
			get => GetProperty(ref _meshOverlayEffectName);
			set => SetProperty(ref _meshOverlayEffectName, value);
		}

		[Ordinal(1)] 
		[RED("meshOverlayEffectTag")] 
		public CName MeshOverlayEffectTag
		{
			get => GetProperty(ref _meshOverlayEffectTag);
			set => SetProperty(ref _meshOverlayEffectTag, value);
		}

		[Ordinal(2)] 
		[RED("meshOverlaySlots")] 
		public CArray<TweakDBID> MeshOverlaySlots
		{
			get => GetProperty(ref _meshOverlaySlots);
			set => SetProperty(ref _meshOverlaySlots, value);
		}
	}
}
