using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationEffector : ActivatedDeviceTransfromAnim
	{
		private CHandle<entIPlacedComponent> _effectComponent;

		[Ordinal(94)] 
		[RED("effectComponent")] 
		public CHandle<entIPlacedComponent> EffectComponent
		{
			get => GetProperty(ref _effectComponent);
			set => SetProperty(ref _effectComponent, value);
		}

		public VentilationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
