using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_EnumSwitch : animAnimNode_InputSwitch
	{
		private CName _enumName;

		[Ordinal(18)] 
		[RED("enumName")] 
		public CName EnumName
		{
			get => GetProperty(ref _enumName);
			set => SetProperty(ref _enumName, value);
		}
	}
}
