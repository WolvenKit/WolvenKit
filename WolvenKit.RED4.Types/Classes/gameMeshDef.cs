using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMeshDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
