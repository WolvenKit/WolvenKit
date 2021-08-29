using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedAnimWrapperVars : RedBaseClass
	{
		private netTime _serverReplicatedTime;
		private CArray<entReplicatedVariableValue> _data;

		[Ordinal(0)] 
		[RED("serverReplicatedTime")] 
		public netTime ServerReplicatedTime
		{
			get => GetProperty(ref _serverReplicatedTime);
			set => SetProperty(ref _serverReplicatedTime, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CArray<entReplicatedVariableValue> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
