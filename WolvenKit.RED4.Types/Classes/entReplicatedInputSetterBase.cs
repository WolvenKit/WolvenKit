using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedInputSetterBase : RedBaseClass
	{
		private CName _name;
		private netTime _applyServerTime;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get => GetProperty(ref _applyServerTime);
			set => SetProperty(ref _applyServerTime, value);
		}
	}
}
