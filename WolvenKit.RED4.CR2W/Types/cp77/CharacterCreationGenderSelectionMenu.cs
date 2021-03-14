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
			get
			{
				if (_streetRat_male == null)
				{
					_streetRat_male = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetRat_male", cr2w, this);
				}
				return _streetRat_male;
			}
			set
			{
				if (_streetRat_male == value)
				{
					return;
				}
				_streetRat_male = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("streetRat_female")] 
		public inkWidgetReference StreetRat_female
		{
			get
			{
				if (_streetRat_female == null)
				{
					_streetRat_female = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetRat_female", cr2w, this);
				}
				return _streetRat_female;
			}
			set
			{
				if (_streetRat_female == value)
				{
					return;
				}
				_streetRat_female = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("clickTarget")] 
		public inkWidgetReference ClickTarget
		{
			get
			{
				if (_clickTarget == null)
				{
					_clickTarget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "clickTarget", cr2w, this);
				}
				return _clickTarget;
			}
			set
			{
				if (_clickTarget == value)
				{
					return;
				}
				_clickTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maleAnimProxy")] 
		public CHandle<inkanimProxy> MaleAnimProxy
		{
			get
			{
				if (_maleAnimProxy == null)
				{
					_maleAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "maleAnimProxy", cr2w, this);
				}
				return _maleAnimProxy;
			}
			set
			{
				if (_maleAnimProxy == value)
				{
					return;
				}
				_maleAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("femaleAnimProxy")] 
		public CHandle<inkanimProxy> FemaleAnimProxy
		{
			get
			{
				if (_femaleAnimProxy == null)
				{
					_femaleAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "femaleAnimProxy", cr2w, this);
				}
				return _femaleAnimProxy;
			}
			set
			{
				if (_femaleAnimProxy == value)
				{
					return;
				}
				_femaleAnimProxy = value;
				PropertySet(this);
			}
		}

		public CharacterCreationGenderSelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
