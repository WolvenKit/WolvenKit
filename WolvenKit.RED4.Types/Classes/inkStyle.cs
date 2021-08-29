using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStyle : RedBaseClass
	{
		private CName _styleID;
		private CName _state;
		private CArray<inkStyleProperty> _properties;

		[Ordinal(0)] 
		[RED("styleID")] 
		public CName StyleID
		{
			get => GetProperty(ref _styleID);
			set => SetProperty(ref _styleID, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CName State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("properties")] 
		public CArray<inkStyleProperty> Properties
		{
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}
	}
}
