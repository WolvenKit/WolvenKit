using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MorphData : IScriptable
	{
		[Ordinal(0)] 
		[RED("changed")] 
		public CBool Changed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MorphData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
