using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplAnimTransformRequestBase : RedBaseClass
	{
		private netTime _applyServerTime;

		[Ordinal(0)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get => GetProperty(ref _applyServerTime);
			set => SetProperty(ref _applyServerTime, value);
		}
	}
}
