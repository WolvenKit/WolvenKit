using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetHealthState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
