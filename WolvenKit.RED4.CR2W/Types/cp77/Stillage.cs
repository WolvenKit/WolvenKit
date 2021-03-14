using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Stillage : InteractiveDevice
	{
		private CHandle<entIPlacedComponent> _collider;

		[Ordinal(93)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get
			{
				if (_collider == null)
				{
					_collider = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "collider", cr2w, this);
				}
				return _collider;
			}
			set
			{
				if (_collider == value)
				{
					return;
				}
				_collider = value;
				PropertySet(this);
			}
		}

		public Stillage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
