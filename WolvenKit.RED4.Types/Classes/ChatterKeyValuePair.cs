using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChatterKeyValuePair : RedBaseClass
	{
		private CRUID _key;
		private CWeakHandle<ChatterLineLogicController> _value;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("Key")] 
		public CRUID Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("Value")] 
		public CWeakHandle<ChatterLineLogicController> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("Owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
