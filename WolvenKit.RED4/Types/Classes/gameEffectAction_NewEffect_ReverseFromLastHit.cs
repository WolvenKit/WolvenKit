using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectAction_NewEffect_ReverseFromLastHit : gameEffectPostAction
	{
		[Ordinal(0)] 
		[RED("tagInThisFile")] 
		public CName TagInThisFile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("childEffect")] 
		public CBool ChildEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("childEffectTag")] 
		public CName ChildEffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectAction_NewEffect_ReverseFromLastHit()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
