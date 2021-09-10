using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SuppressOutlineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requestToSuppress")] 
		public CHandle<OutlineRequest> RequestToSuppress
		{
			get => GetPropertyValue<CHandle<OutlineRequest>>();
			set => SetPropertyValue<CHandle<OutlineRequest>>(value);
		}
	}
}
