using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateFastTravelPointRecordRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("pointRecord")] 
		public TweakDBID PointRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
