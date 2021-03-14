using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFastTravelLoadingControllerSupervisor : gameuiWidgetGameController
	{
		private rRef<worldEffect> _glitchEffect;

		[Ordinal(2)] 
		[RED("glitchEffect")] 
		public rRef<worldEffect> GlitchEffect
		{
			get
			{
				if (_glitchEffect == null)
				{
					_glitchEffect = (rRef<worldEffect>) CR2WTypeManager.Create("rRef:worldEffect", "glitchEffect", cr2w, this);
				}
				return _glitchEffect;
			}
			set
			{
				if (_glitchEffect == value)
				{
					return;
				}
				_glitchEffect = value;
				PropertySet(this);
			}
		}

		public inkFastTravelLoadingControllerSupervisor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
