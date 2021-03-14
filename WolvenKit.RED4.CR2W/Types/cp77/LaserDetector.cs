using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LaserDetector : ProximityDetector
	{
		private CArrayFixedSize<CHandle<entMeshComponent>> _lasers;

		[Ordinal(92)] 
		[RED("lasers", 2)] 
		public CArrayFixedSize<CHandle<entMeshComponent>> Lasers
		{
			get
			{
				if (_lasers == null)
				{
					_lasers = (CArrayFixedSize<CHandle<entMeshComponent>>) CR2WTypeManager.Create("[2]handle:entMeshComponent", "lasers", cr2w, this);
				}
				return _lasers;
			}
			set
			{
				if (_lasers == value)
				{
					return;
				}
				_lasers = value;
				PropertySet(this);
			}
		}

		public LaserDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
