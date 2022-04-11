using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDamageInfoUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("flags")] 
		public CArray<SHitFlag> Flags
		{
			get => GetPropertyValue<CArray<SHitFlag>>();
			set => SetPropertyValue<CArray<SHitFlag>>(value);
		}

		[Ordinal(1)] 
		[RED("hitShapeType")] 
		public CEnum<EHitShapeType> HitShapeType
		{
			get => GetPropertyValue<CEnum<EHitShapeType>>();
			set => SetPropertyValue<CEnum<EHitShapeType>>(value);
		}

		public gameuiDamageInfoUserData()
		{
			Flags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
