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
			get
			{
				if (_effectComponent == null)
				{
					_effectComponent = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "effectComponent", cr2w, this);
				}
				return _effectComponent;
			}
			set
			{
				if (_effectComponent == value)
				{
					return;
				}
				_effectComponent = value;
				PropertySet(this);
			}
		}

		public VentilationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
