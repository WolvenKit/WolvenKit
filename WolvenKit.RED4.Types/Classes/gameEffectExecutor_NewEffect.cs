using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_NewEffect : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("tagInThisFile")] 
		public CName TagInThisFile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("childEffect")] 
		public CBool ChildEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("childEffectTag")] 
		public CName ChildEffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectExecutor_NewEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
