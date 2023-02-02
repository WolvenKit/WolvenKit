using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimSequence : IScriptable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("definitions")] 
		public CArray<CHandle<inkanimDefinition>> Definitions
		{
			get => GetPropertyValue<CArray<CHandle<inkanimDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimDefinition>>>(value);
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<CHandle<inkanimSequenceTargetInfo>> Targets
		{
			get => GetPropertyValue<CArray<CHandle<inkanimSequenceTargetInfo>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimSequenceTargetInfo>>>(value);
		}

		public inkanimSequence()
		{
			Definitions = new();
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
