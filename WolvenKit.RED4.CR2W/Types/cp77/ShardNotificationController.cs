using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardNotificationController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _shortTextRef;
		private inkTextWidgetReference _longTextRef;
		private inkWidgetReference _shortTextHolderRef;
		private inkWidgetReference _longTextHolderRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _buttonHintsManagerParentRef;
		private inkWidgetReference _buttonHintsSecondaryManagerRef;
		private inkWidgetReference _buttonHintsSecondaryManagerParentRef;
		private CHandle<ShardReadPopupData> _data;
		private CInt32 _longTextTrashold;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameIBlackboard> _mingameBB;

		[Ordinal(2)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetProperty(ref _titleRef);
			set => SetProperty(ref _titleRef, value);
		}

		[Ordinal(3)] 
		[RED("shortTextRef")] 
		public inkTextWidgetReference ShortTextRef
		{
			get => GetProperty(ref _shortTextRef);
			set => SetProperty(ref _shortTextRef, value);
		}

		[Ordinal(4)] 
		[RED("longTextRef")] 
		public inkTextWidgetReference LongTextRef
		{
			get => GetProperty(ref _longTextRef);
			set => SetProperty(ref _longTextRef, value);
		}

		[Ordinal(5)] 
		[RED("shortTextHolderRef")] 
		public inkWidgetReference ShortTextHolderRef
		{
			get => GetProperty(ref _shortTextHolderRef);
			set => SetProperty(ref _shortTextHolderRef, value);
		}

		[Ordinal(6)] 
		[RED("longTextHolderRef")] 
		public inkWidgetReference LongTextHolderRef
		{
			get => GetProperty(ref _longTextHolderRef);
			set => SetProperty(ref _longTextHolderRef, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerParentRef")] 
		public inkWidgetReference ButtonHintsManagerParentRef
		{
			get => GetProperty(ref _buttonHintsManagerParentRef);
			set => SetProperty(ref _buttonHintsManagerParentRef, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsSecondaryManagerRef")] 
		public inkWidgetReference ButtonHintsSecondaryManagerRef
		{
			get => GetProperty(ref _buttonHintsSecondaryManagerRef);
			set => SetProperty(ref _buttonHintsSecondaryManagerRef, value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsSecondaryManagerParentRef")] 
		public inkWidgetReference ButtonHintsSecondaryManagerParentRef
		{
			get => GetProperty(ref _buttonHintsSecondaryManagerParentRef);
			set => SetProperty(ref _buttonHintsSecondaryManagerParentRef, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<ShardReadPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("longTextTrashold")] 
		public CInt32 LongTextTrashold
		{
			get => GetProperty(ref _longTextTrashold);
			set => SetProperty(ref _longTextTrashold, value);
		}

		[Ordinal(13)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(14)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(15)] 
		[RED("mingameBB")] 
		public CHandle<gameIBlackboard> MingameBB
		{
			get => GetProperty(ref _mingameBB);
			set => SetProperty(ref _mingameBB, value);
		}

		public ShardNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
