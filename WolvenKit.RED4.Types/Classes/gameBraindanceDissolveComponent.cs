using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBraindanceDissolveComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("dissolveRadius")] 
		public CFloat DissolveRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBraindanceDissolveComponent()
		{
			Name = "Component";
			DissolveRadius = 0.600000F;
		}
	}
}
