using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRadialWipeEffect : inkIEffect
	{
		private CFloat _startAngle;
		private CFloat _transition;

		[Ordinal(2)] 
		[RED("startAngle")] 
		public CFloat StartAngle
		{
			get
			{
				if (_startAngle == null)
				{
					_startAngle = (CFloat) CR2WTypeManager.Create("Float", "startAngle", cr2w, this);
				}
				return _startAngle;
			}
			set
			{
				if (_startAngle == value)
				{
					return;
				}
				_startAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transition")] 
		public CFloat Transition
		{
			get
			{
				if (_transition == null)
				{
					_transition = (CFloat) CR2WTypeManager.Create("Float", "transition", cr2w, this);
				}
				return _transition;
			}
			set
			{
				if (_transition == value)
				{
					return;
				}
				_transition = value;
				PropertySet(this);
			}
		}

		public inkRadialWipeEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
