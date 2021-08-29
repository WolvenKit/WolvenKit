using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpAnimFeature_Stairs : animAnimFeature
	{
		private CBool _onOff;

		[Ordinal(0)] 
		[RED("onOff")] 
		public CBool OnOff
		{
			get => GetProperty(ref _onOff);
			set => SetProperty(ref _onOff, value);
		}
	}
}
