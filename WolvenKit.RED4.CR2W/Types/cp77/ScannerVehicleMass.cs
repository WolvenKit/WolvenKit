using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleMass : ScannerChunk
	{
		private CInt32 _mass;

		[Ordinal(0)] 
		[RED("mass")] 
		public CInt32 Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CInt32) CR2WTypeManager.Create("Int32", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleMass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
