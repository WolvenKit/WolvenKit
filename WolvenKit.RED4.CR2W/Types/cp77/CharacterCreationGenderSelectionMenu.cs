using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationGenderSelectionMenu : gameuiBaseCharacterCreationController
	{
		private inkWidgetReference _streetRat_male;
		private inkWidgetReference _streetRat_female;
		private inkWidgetReference _clickTarget;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _maleAnimProxy;
		private CHandle<inkanimProxy> _femaleAnimProxy;

		[Ordinal(6)] 
		[RED("streetRat_male")] 
		public inkWidgetReference StreetRat_male
		{
			get => GetProperty(ref _streetRat_male);
			set => SetProperty(ref _streetRat_male, value);
		}

		[Ordinal(7)] 
		[RED("streetRat_female")] 
		public inkWidgetReference StreetRat_female
		{
			get => GetProperty(ref _streetRat_female);
			set => SetProperty(ref _streetRat_female, value);
		}

		[Ordinal(8)] 
		[RED("clickTarget")] 
		public inkWidgetReference ClickTarget
		{
			get => GetProperty(ref _clickTarget);
			set => SetProperty(ref _clickTarget, value);
		}

		[Ordinal(9)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(10)] 
		[RED("maleAnimProxy")] 
		public CHandle<inkanimProxy> MaleAnimProxy
		{
			get => GetProperty(ref _maleAnimProxy);
			set => SetProperty(ref _maleAnimProxy, value);
		}

		[Ordinal(11)] 
		[RED("femaleAnimProxy")] 
		public CHandle<inkanimProxy> FemaleAnimProxy
		{
			get => GetProperty(ref _femaleAnimProxy);
			set => SetProperty(ref _femaleAnimProxy, value);
		}

		public CharacterCreationGenderSelectionMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
