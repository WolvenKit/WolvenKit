using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UiRadialContextEvents : InputContextTransitionEvents
	{
		private Vector4 _mouse;

		[Ordinal(0)] 
		[RED("mouse")] 
		public Vector4 Mouse
		{
			get
			{
				if (_mouse == null)
				{
					_mouse = (Vector4) CR2WTypeManager.Create("Vector4", "mouse", cr2w, this);
				}
				return _mouse;
			}
			set
			{
				if (_mouse == value)
				{
					return;
				}
				_mouse = value;
				PropertySet(this);
			}
		}

		public UiRadialContextEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
