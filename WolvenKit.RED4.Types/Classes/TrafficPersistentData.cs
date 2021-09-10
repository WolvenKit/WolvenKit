using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
