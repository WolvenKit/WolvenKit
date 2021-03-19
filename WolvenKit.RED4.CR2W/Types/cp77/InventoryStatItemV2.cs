using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItemV2 : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelRef;
		private inkTextWidgetReference _valueRef;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _backgroundIcon;
		private inkWidgetReference _textGroup;
		private CBool _introPlayed;

		[Ordinal(1)] 
		[RED("LabelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetProperty(ref _labelRef);
			set => SetProperty(ref _labelRef, value);
		}

		[Ordinal(2)] 
		[RED("ValueRef")] 
		public inkTextWidgetReference ValueRef
		{
			get => GetProperty(ref _valueRef);
			set => SetProperty(ref _valueRef, value);
		}

		[Ordinal(3)] 
		[RED("Icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(4)] 
		[RED("BackgroundIcon")] 
		public inkImageWidgetReference BackgroundIcon
		{
			get => GetProperty(ref _backgroundIcon);
			set => SetProperty(ref _backgroundIcon, value);
		}

		[Ordinal(5)] 
		[RED("TextGroup")] 
		public inkWidgetReference TextGroup
		{
			get => GetProperty(ref _textGroup);
			set => SetProperty(ref _textGroup, value);
		}

		[Ordinal(6)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get => GetProperty(ref _introPlayed);
			set => SetProperty(ref _introPlayed, value);
		}

		public InventoryStatItemV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
