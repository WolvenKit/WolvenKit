using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCutControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCutControlNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
