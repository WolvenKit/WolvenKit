using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_SetLowGravity : questICharacterManagerParameters_NodeSubType
	{
		private CBool _enable;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public questCharacterManagerParameters_SetLowGravity()
		{
			_enable = true;
		}
	}
}
