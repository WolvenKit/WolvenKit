using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAdvertGlitchEvent : redEvent
	{
		private CFloat _glitchValue;

		[Ordinal(0)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get
			{
				if (_glitchValue == null)
				{
					_glitchValue = (CFloat) CR2WTypeManager.Create("Float", "glitchValue", cr2w, this);
				}
				return _glitchValue;
			}
			set
			{
				if (_glitchValue == value)
				{
					return;
				}
				_glitchValue = value;
				PropertySet(this);
			}
		}

		public gameuiAdvertGlitchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
