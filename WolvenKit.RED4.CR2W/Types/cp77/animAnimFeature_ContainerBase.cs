using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ContainerBase : animAnimFeature
	{
		private CBool _opened;
		private CFloat _transitionDuration;

		[Ordinal(0)] 
		[RED("opened")] 
		public CBool Opened
		{
			get
			{
				if (_opened == null)
				{
					_opened = (CBool) CR2WTypeManager.Create("Bool", "opened", cr2w, this);
				}
				return _opened;
			}
			set
			{
				if (_opened == value)
				{
					return;
				}
				_opened = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get
			{
				if (_transitionDuration == null)
				{
					_transitionDuration = (CFloat) CR2WTypeManager.Create("Float", "transitionDuration", cr2w, this);
				}
				return _transitionDuration;
			}
			set
			{
				if (_transitionDuration == value)
				{
					return;
				}
				_transitionDuration = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_ContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
