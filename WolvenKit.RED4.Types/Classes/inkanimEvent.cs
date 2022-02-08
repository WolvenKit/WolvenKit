using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimEvent : IScriptable
	{
		[Ordinal(0)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
