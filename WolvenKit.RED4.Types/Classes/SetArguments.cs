using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetArguments : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("argumentVar")] 
		public CName ArgumentVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
