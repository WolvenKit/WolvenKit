using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollComponent : entIComponent
	{
		private CBool _isEnabled;

		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public entRagdollComponent()
		{
			_isEnabled = true;
		}
	}
}
