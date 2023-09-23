using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyQuickhackEffector : AbstractApplyQuickhackEffector
	{
		[Ordinal(2)] 
		[RED("quickhackObjectActionID")] 
		public TweakDBID QuickhackObjectActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("quickhackObjectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> QuickhackObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(4)] 
		[RED("MaxUploadChance")] 
		public CFloat MaxUploadChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ApplyQuickhackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
