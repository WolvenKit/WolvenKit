using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryFilterButton : BaseButtonView
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _inputIcon;
		private CBool _introPlayed;

		[Ordinal(2)] 
		[RED("Label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("InputIcon")] 
		public inkImageWidgetReference InputIcon
		{
			get => GetProperty(ref _inputIcon);
			set => SetProperty(ref _inputIcon, value);
		}

		[Ordinal(4)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get => GetProperty(ref _introPlayed);
			set => SetProperty(ref _introPlayed, value);
		}

		public InventoryFilterButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
