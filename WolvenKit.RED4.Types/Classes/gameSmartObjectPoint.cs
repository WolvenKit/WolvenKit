using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectPoint : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
