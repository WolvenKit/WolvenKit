using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuItemDimRequest : redEvent
	{
		private CBool _dim;

		[Ordinal(0)] 
		[RED("dim")] 
		public CBool Dim
		{
			get => GetProperty(ref _dim);
			set => SetProperty(ref _dim, value);
		}
	}
}
