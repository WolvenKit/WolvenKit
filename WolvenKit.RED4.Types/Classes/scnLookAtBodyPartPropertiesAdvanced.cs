using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLookAtBodyPartPropertiesAdvanced : RedBaseClass
	{
		private CName _bodyPartName;

		[Ordinal(0)] 
		[RED("bodyPartName")] 
		public CName BodyPartName
		{
			get => GetProperty(ref _bodyPartName);
			set => SetProperty(ref _bodyPartName, value);
		}
	}
}
