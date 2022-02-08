using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIBuffInfo : gameuiBuffInfo
	{
		[Ordinal(2)] 
		[RED("isBuff")] 
		public CBool IsBuff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
