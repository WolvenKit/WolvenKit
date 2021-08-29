using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMinimize_NodeType : questIPhoneManagerNodeType
	{
		private CBool _minimize;

		[Ordinal(0)] 
		[RED("minimize")] 
		public CBool Minimize
		{
			get => GetProperty(ref _minimize);
			set => SetProperty(ref _minimize, value);
		}
	}
}
