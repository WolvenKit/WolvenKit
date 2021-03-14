using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleHorsepower : ScannerChunk
	{
		private CInt32 _horsepower;

		[Ordinal(0)] 
		[RED("horsepower")] 
		public CInt32 Horsepower
		{
			get
			{
				if (_horsepower == null)
				{
					_horsepower = (CInt32) CR2WTypeManager.Create("Int32", "horsepower", cr2w, this);
				}
				return _horsepower;
			}
			set
			{
				if (_horsepower == value)
				{
					return;
				}
				_horsepower = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleHorsepower(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
