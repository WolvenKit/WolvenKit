using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqParams : RedBaseClass
	{
		private gameStatsObjectID _objectID;
		private gameStatsObjectID _otherObjectID;
		private CVariant _otherData;

		[Ordinal(0)] 
		[RED("objectID")] 
		public gameStatsObjectID ObjectID
		{
			get => GetProperty(ref _objectID);
			set => SetProperty(ref _objectID, value);
		}

		[Ordinal(1)] 
		[RED("otherObjectID")] 
		public gameStatsObjectID OtherObjectID
		{
			get => GetProperty(ref _otherObjectID);
			set => SetProperty(ref _otherObjectID, value);
		}

		[Ordinal(2)] 
		[RED("otherData")] 
		public CVariant OtherData
		{
			get => GetProperty(ref _otherData);
			set => SetProperty(ref _otherData, value);
		}
	}
}
