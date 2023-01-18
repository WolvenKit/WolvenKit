using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedamageServerHitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("damageInfos")] 
		public CArray<gameuiDamageInfo> DamageInfos
		{
			get => GetPropertyValue<CArray<gameuiDamageInfo>>();
			set => SetPropertyValue<CArray<gameuiDamageInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public gamedamageServerHitData()
		{
			DamageInfos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
