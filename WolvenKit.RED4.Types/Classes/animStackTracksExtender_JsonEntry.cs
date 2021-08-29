using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animStackTracksExtender_JsonEntry : RedBaseClass
	{
		private CName _name;
		private CFloat _referenceValue;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("referenceValue")] 
		public CFloat ReferenceValue
		{
			get => GetProperty(ref _referenceValue);
			set => SetProperty(ref _referenceValue, value);
		}
	}
}
