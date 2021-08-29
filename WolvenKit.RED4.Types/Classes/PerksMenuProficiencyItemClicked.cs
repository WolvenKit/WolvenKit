using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		private CInt32 _index;

		[Ordinal(3)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}
	}
}
