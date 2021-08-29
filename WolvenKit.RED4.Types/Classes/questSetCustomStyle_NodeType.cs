using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetCustomStyle_NodeType : questIPhoneManagerNodeType
	{
		private CEnum<questCustomStyle> _style;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("style")] 
		public CEnum<questCustomStyle> Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}
	}
}
