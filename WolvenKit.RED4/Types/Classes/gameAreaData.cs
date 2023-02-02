using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAreaData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CFloat Size
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gameEAreaType> Type
		{
			get => GetPropertyValue<CEnum<gameEAreaType>>();
			set => SetPropertyValue<CEnum<gameEAreaType>>(value);
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public CEnum<gameEAreaShape> Shape
		{
			get => GetPropertyValue<CEnum<gameEAreaShape>>();
			set => SetPropertyValue<CEnum<gameEAreaShape>>(value);
		}

		[Ordinal(4)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameAreaData()
		{
			Position = new() { W = 1.000000F };
			Size = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
