using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUseWeapon_MissileRainGrid_NodeType : questUseWeapon_NodeType
	{
		[Ordinal(5)] 
		[RED("source")] 
		public CEnum<questEUseWeapon_MissileOffsetsSource> Source
		{
			get => GetPropertyValue<CEnum<questEUseWeapon_MissileOffsetsSource>>();
			set => SetPropertyValue<CEnum<questEUseWeapon_MissileOffsetsSource>>(value);
		}

		[Ordinal(6)] 
		[RED("missileOffsets")] 
		public CArray<Vector3> MissileOffsets
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(7)] 
		[RED("targetRefs")] 
		public CArray<gameEntityReference> TargetRefs
		{
			get => GetPropertyValue<CArray<gameEntityReference>>();
			set => SetPropertyValue<CArray<gameEntityReference>>(value);
		}

		[Ordinal(8)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questUseWeapon_MissileRainGrid_NodeType()
		{
			MissileOffsets = new();
			TargetRefs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
