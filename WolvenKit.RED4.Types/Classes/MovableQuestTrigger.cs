using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableQuestTrigger : gameObject
	{
		private CName _factName;
		private CBool _onlyDetectsPlayer;

		[Ordinal(40)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(41)] 
		[RED("onlyDetectsPlayer")] 
		public CBool OnlyDetectsPlayer
		{
			get => GetProperty(ref _onlyDetectsPlayer);
			set => SetProperty(ref _onlyDetectsPlayer, value);
		}
	}
}
