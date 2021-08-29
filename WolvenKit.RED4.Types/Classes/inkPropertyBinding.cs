using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPropertyBinding : RedBaseClass
	{
		private CName _propertyName;
		private CName _stylePath;

		[Ordinal(0)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get => GetProperty(ref _propertyName);
			set => SetProperty(ref _propertyName, value);
		}

		[Ordinal(1)] 
		[RED("stylePath")] 
		public CName StylePath
		{
			get => GetProperty(ref _stylePath);
			set => SetProperty(ref _stylePath, value);
		}
	}
}
