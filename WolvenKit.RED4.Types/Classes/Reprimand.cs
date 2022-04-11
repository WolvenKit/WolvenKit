using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Reprimand : MorphData
	{
		[Ordinal(1)] 
		[RED("reprimandData")] 
		public ReprimandData ReprimandData
		{
			get => GetPropertyValue<ReprimandData>();
			set => SetPropertyValue<ReprimandData>(value);
		}

		public Reprimand()
		{
			ReprimandData = new() { Receiver = new() };
		}
	}
}
