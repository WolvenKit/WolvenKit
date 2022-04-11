using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<questPuppetsEffector> Effector
		{
			get => GetPropertyValue<CHandle<questPuppetsEffector>>();
			set => SetPropertyValue<CHandle<questPuppetsEffector>>(value);
		}

		[Ordinal(3)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questPuppeteerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Reference = new() { Names = new() };
		}
	}
}
