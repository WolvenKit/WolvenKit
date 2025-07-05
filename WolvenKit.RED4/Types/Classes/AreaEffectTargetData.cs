using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaEffectTargetData : IScriptable
	{
		[Ordinal(0)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("onSelf")] 
		public CBool OnSelf
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("onSlaves")] 
		public CBool OnSlaves
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AreaEffectTargetData()
		{
			OnSelf = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
