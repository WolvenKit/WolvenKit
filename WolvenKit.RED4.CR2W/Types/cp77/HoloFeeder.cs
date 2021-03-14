using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloFeeder : Device
	{
		private CHandle<entIPlacedComponent> _feederMesh;

		[Ordinal(86)] 
		[RED("feederMesh")] 
		public CHandle<entIPlacedComponent> FeederMesh
		{
			get
			{
				if (_feederMesh == null)
				{
					_feederMesh = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "feederMesh", cr2w, this);
				}
				return _feederMesh;
			}
			set
			{
				if (_feederMesh == value)
				{
					return;
				}
				_feederMesh = value;
				PropertySet(this);
			}
		}

		public HoloFeeder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
