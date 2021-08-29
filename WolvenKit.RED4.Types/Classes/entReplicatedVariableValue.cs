using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedVariableValue : RedBaseClass
	{
		private CName _name;
		private CFloat _value;
		private netTime _applyServerTime;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get => GetProperty(ref _applyServerTime);
			set => SetProperty(ref _applyServerTime, value);
		}
	}
}
