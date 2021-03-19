using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _msgCount;
		private inkWidgetReference _msgIndicator;
		private inkWidgetReference _questFlag;
		private inkWidgetReference _regFlag;
		private CHandle<inkanimProxy> _animProxyQuest;
		private CHandle<inkanimProxy> _animProxySelection;
		private CHandle<ContactData> _contactData;

		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(16)] 
		[RED("msgCount")] 
		public inkTextWidgetReference MsgCount
		{
			get => GetProperty(ref _msgCount);
			set => SetProperty(ref _msgCount, value);
		}

		[Ordinal(17)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetProperty(ref _msgIndicator);
			set => SetProperty(ref _msgIndicator, value);
		}

		[Ordinal(18)] 
		[RED("questFlag")] 
		public inkWidgetReference QuestFlag
		{
			get => GetProperty(ref _questFlag);
			set => SetProperty(ref _questFlag, value);
		}

		[Ordinal(19)] 
		[RED("regFlag")] 
		public inkWidgetReference RegFlag
		{
			get => GetProperty(ref _regFlag);
			set => SetProperty(ref _regFlag, value);
		}

		[Ordinal(20)] 
		[RED("animProxyQuest")] 
		public CHandle<inkanimProxy> AnimProxyQuest
		{
			get => GetProperty(ref _animProxyQuest);
			set => SetProperty(ref _animProxyQuest, value);
		}

		[Ordinal(21)] 
		[RED("animProxySelection")] 
		public CHandle<inkanimProxy> AnimProxySelection
		{
			get => GetProperty(ref _animProxySelection);
			set => SetProperty(ref _animProxySelection, value);
		}

		[Ordinal(22)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetProperty(ref _contactData);
			set => SetProperty(ref _contactData, value);
		}

		public PhoneContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
