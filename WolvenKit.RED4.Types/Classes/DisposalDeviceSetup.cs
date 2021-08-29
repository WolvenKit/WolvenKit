using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisposalDeviceSetup : RedBaseClass
	{
		private CInt32 _numberOfUses;
		private CBool _isBodyRequired;
		private TweakDBID _actionName;
		private TweakDBID _takedownActionName;
		private TweakDBID _nonlethalTakedownActionName;

		[Ordinal(0)] 
		[RED("numberOfUses")] 
		public CInt32 NumberOfUses
		{
			get => GetProperty(ref _numberOfUses);
			set => SetProperty(ref _numberOfUses, value);
		}

		[Ordinal(1)] 
		[RED("isBodyRequired")] 
		public CBool IsBodyRequired
		{
			get => GetProperty(ref _isBodyRequired);
			set => SetProperty(ref _isBodyRequired, value);
		}

		[Ordinal(2)] 
		[RED("actionName")] 
		public TweakDBID ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(3)] 
		[RED("takedownActionName")] 
		public TweakDBID TakedownActionName
		{
			get => GetProperty(ref _takedownActionName);
			set => SetProperty(ref _takedownActionName, value);
		}

		[Ordinal(4)] 
		[RED("nonlethalTakedownActionName")] 
		public TweakDBID NonlethalTakedownActionName
		{
			get => GetProperty(ref _nonlethalTakedownActionName);
			set => SetProperty(ref _nonlethalTakedownActionName, value);
		}
	}
}
