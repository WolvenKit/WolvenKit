using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlots : entIComponent
	{
		private CArray<gameAnimParamSlotsOption> _animParams;

		[Ordinal(3)] 
		[RED("animParams")] 
		public CArray<gameAnimParamSlotsOption> AnimParams
		{
			get => GetProperty(ref _animParams);
			set => SetProperty(ref _animParams, value);
		}
	}
}
