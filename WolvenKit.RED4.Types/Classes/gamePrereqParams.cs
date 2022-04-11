using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectID")] 
		public gameStatsObjectID ObjectID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(1)] 
		[RED("otherObjectID")] 
		public gameStatsObjectID OtherObjectID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(2)] 
		[RED("otherData")] 
		public CVariant OtherData
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public gamePrereqParams()
		{
			ObjectID = new() { IdType = Enums.gameStatIDType.Invalid };
			OtherObjectID = new() { IdType = Enums.gameStatIDType.Invalid };
		}
	}
}
