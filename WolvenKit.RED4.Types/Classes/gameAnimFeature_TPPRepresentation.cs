using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimFeature_TPPRepresentation : animAnimFeature
	{
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}
	}
}
