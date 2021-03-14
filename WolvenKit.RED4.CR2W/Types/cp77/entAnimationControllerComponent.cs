using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationControllerComponent : entIComponent
	{
		private rRef<animActionAnimDatabase> _actionAnimDatabaseRef;
		private animAnimDatabaseCollection _animDatabaseCollection;
		private CHandle<entAnimationControlBinding> _controlBinding;

		[Ordinal(3)] 
		[RED("actionAnimDatabaseRef")] 
		public rRef<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get
			{
				if (_actionAnimDatabaseRef == null)
				{
					_actionAnimDatabaseRef = (rRef<animActionAnimDatabase>) CR2WTypeManager.Create("rRef:animActionAnimDatabase", "actionAnimDatabaseRef", cr2w, this);
				}
				return _actionAnimDatabaseRef;
			}
			set
			{
				if (_actionAnimDatabaseRef == value)
				{
					return;
				}
				_actionAnimDatabaseRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animDatabaseCollection")] 
		public animAnimDatabaseCollection AnimDatabaseCollection
		{
			get
			{
				if (_animDatabaseCollection == null)
				{
					_animDatabaseCollection = (animAnimDatabaseCollection) CR2WTypeManager.Create("animAnimDatabaseCollection", "animDatabaseCollection", cr2w, this);
				}
				return _animDatabaseCollection;
			}
			set
			{
				if (_animDatabaseCollection == value)
				{
					return;
				}
				_animDatabaseCollection = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get
			{
				if (_controlBinding == null)
				{
					_controlBinding = (CHandle<entAnimationControlBinding>) CR2WTypeManager.Create("handle:entAnimationControlBinding", "controlBinding", cr2w, this);
				}
				return _controlBinding;
			}
			set
			{
				if (_controlBinding == value)
				{
					return;
				}
				_controlBinding = value;
				PropertySet(this);
			}
		}

		public entAnimationControllerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
