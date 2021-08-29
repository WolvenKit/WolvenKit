using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NameplateVisibleEvent : redEvent
	{
		private CBool _isNameplateVisible;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get => GetProperty(ref _isNameplateVisible);
			set => SetProperty(ref _isNameplateVisible, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}
	}
}
