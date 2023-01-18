using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimationChain : IScriptable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<AnimationElement> Data
		{
			get => GetPropertyValue<CArray<AnimationElement>>();
			set => SetPropertyValue<CArray<AnimationElement>>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AnimationChain()
		{
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
