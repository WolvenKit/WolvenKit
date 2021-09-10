using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HubMenuInstanceData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
