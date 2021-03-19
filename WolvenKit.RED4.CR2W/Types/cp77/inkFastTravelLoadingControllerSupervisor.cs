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
			get => GetProperty(ref _glitchEffect);
			set => SetProperty(ref _glitchEffect, value);
		}

		public inkFastTravelLoadingControllerSupervisor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
