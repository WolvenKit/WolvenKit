using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationBackstorySelectionMenu : gameuiBaseCharacterCreationController
	{
		private inkWidgetReference _nomad;
		private inkWidgetReference _streetRat;
		private inkWidgetReference _corpo;
		private CHandle<inkanimProxy> _animationProxy;
		private CString _clickTarget;
		private CString _nomadTarget;
		private CString _streetTarget;
		private CString _corpoTarget;

		[Ordinal(6)] 
		[RED("nomad")] 
		public inkWidgetReference Nomad
		{
			get
			{
				if (_nomad == null)
				{
					_nomad = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nomad", cr2w, this);
				}
				return _nomad;
			}
			set
			{
				if (_nomad == value)
				{
					return;
				}
				_nomad = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("streetRat")] 
		public inkWidgetReference StreetRat
		{
			get
			{
				if (_streetRat == null)
				{
					_streetRat = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetRat", cr2w, this);
				}
				return _streetRat;
			}
			set
			{
				if (_streetRat == value)
				{
					return;
				}
				_streetRat = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("corpo")] 
		public inkWidgetReference Corpo
		{
			get
			{
				if (_corpo == null)
				{
					_corpo = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "corpo", cr2w, this);
				}
				return _corpo;
			}
			set
			{
				if (_corpo == value)
				{
					return;
				}
				_corpo = value;
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
		[RED("clickTarget")] 
		public CString ClickTarget
		{
			get
			{
				if (_clickTarget == null)
				{
					_clickTarget = (CString) CR2WTypeManager.Create("String", "clickTarget", cr2w, this);
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

		[Ordinal(11)] 
		[RED("nomadTarget")] 
		public CString NomadTarget
		{
			get
			{
				if (_nomadTarget == null)
				{
					_nomadTarget = (CString) CR2WTypeManager.Create("String", "nomadTarget", cr2w, this);
				}
				return _nomadTarget;
			}
			set
			{
				if (_nomadTarget == value)
				{
					return;
				}
				_nomadTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("streetTarget")] 
		public CString StreetTarget
		{
			get
			{
				if (_streetTarget == null)
				{
					_streetTarget = (CString) CR2WTypeManager.Create("String", "streetTarget", cr2w, this);
				}
				return _streetTarget;
			}
			set
			{
				if (_streetTarget == value)
				{
					return;
				}
				_streetTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("corpoTarget")] 
		public CString CorpoTarget
		{
			get
			{
				if (_corpoTarget == null)
				{
					_corpoTarget = (CString) CR2WTypeManager.Create("String", "corpoTarget", cr2w, this);
				}
				return _corpoTarget;
			}
			set
			{
				if (_corpoTarget == value)
				{
					return;
				}
				_corpoTarget = value;
				PropertySet(this);
			}
		}

		public CharacterCreationBackstorySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
