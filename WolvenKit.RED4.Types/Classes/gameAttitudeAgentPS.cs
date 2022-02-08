using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttitudeAgentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("currentAttitudeGroup")] 
		public CName CurrentAttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
