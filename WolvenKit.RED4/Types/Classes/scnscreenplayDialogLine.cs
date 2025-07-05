using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnscreenplayDialogLine : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetPropertyValue<scnscreenplayItemId>();
			set => SetPropertyValue<scnscreenplayItemId>(value);
		}

		[Ordinal(1)] 
		[RED("speaker")] 
		public scnActorId Speaker
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(2)] 
		[RED("addressee")] 
		public scnActorId Addressee
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(3)] 
		[RED("usage")] 
		public scnscreenplayLineUsage Usage
		{
			get => GetPropertyValue<scnscreenplayLineUsage>();
			set => SetPropertyValue<scnscreenplayLineUsage>(value);
		}

		[Ordinal(4)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get => GetPropertyValue<scnlocLocstringId>();
			set => SetPropertyValue<scnlocLocstringId>(value);
		}

		[Ordinal(5)] 
		[RED("maleLipsyncAnimationName")] 
		public CName MaleLipsyncAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("femaleLipsyncAnimationName")] 
		public CName FemaleLipsyncAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnscreenplayDialogLine()
		{
			ItemId = new scnscreenplayItemId { Id = 4294967040 };
			Speaker = new scnActorId { Id = uint.MaxValue };
			Addressee = new scnActorId { Id = uint.MaxValue };
			Usage = new scnscreenplayLineUsage { PlayerGenderMask = new scnGenderMask { Mask = 128 } };
			LocstringId = new scnlocLocstringId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
