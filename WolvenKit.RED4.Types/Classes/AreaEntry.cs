using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("user")] 
		public entEntityID User
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public AreaEntry()
		{
			User = new();
		}
	}
}
