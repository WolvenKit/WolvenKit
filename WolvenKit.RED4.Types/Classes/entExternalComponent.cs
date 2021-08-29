using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entExternalComponent : entIComponent
	{
		private CName _externalComponentName;

		[Ordinal(3)] 
		[RED("externalComponentName")] 
		public CName ExternalComponentName
		{
			get => GetProperty(ref _externalComponentName);
			set => SetProperty(ref _externalComponentName, value);
		}
	}
}
