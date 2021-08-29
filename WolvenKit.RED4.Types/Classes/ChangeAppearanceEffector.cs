using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeAppearanceEffector : gameEffector
	{
		private CName _appearanceName;
		private CBool _resetAppearance;
		private CName _previousAppearance;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(1)] 
		[RED("resetAppearance")] 
		public CBool ResetAppearance
		{
			get => GetProperty(ref _resetAppearance);
			set => SetProperty(ref _resetAppearance, value);
		}

		[Ordinal(2)] 
		[RED("previousAppearance")] 
		public CName PreviousAppearance
		{
			get => GetProperty(ref _previousAppearance);
			set => SetProperty(ref _previousAppearance, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
