using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OptionalAreaEffectData : IScriptable
	{
		[Ordinal(0)] 
		[RED("includeInAoeData")] 
		public CBool IncludeInAoeData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("aoeData")] 
		public CHandle<AreaEffectData> AoeData
		{
			get => GetPropertyValue<CHandle<AreaEffectData>>();
			set => SetPropertyValue<CHandle<AreaEffectData>>(value);
		}

		public OptionalAreaEffectData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
