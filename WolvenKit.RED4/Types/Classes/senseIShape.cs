using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseIShape : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public senseIShape()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
