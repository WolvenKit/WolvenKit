using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questContentLock_ConditionType : questIContentConditionType
	{
		[Ordinal(0)] 
		[RED("isContentBlocked")] 
		public CBool IsContentBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
