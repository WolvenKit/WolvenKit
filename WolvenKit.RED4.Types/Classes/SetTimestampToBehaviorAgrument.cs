using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetTimestampToBehaviorAgrument : AIbehaviortaskScript
	{
		private CName _timestampArgument;

		[Ordinal(0)] 
		[RED("timestampArgument")] 
		public CName TimestampArgument
		{
			get => GetProperty(ref _timestampArgument);
			set => SetProperty(ref _timestampArgument, value);
		}
	}
}
