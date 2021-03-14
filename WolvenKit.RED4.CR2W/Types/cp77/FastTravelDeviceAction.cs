using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelDeviceAction : ActionBool
	{
		private CHandle<gameFastTravelPointData> _fastTravelPointData;

		[Ordinal(25)] 
		[RED("fastTravelPointData")] 
		public CHandle<gameFastTravelPointData> FastTravelPointData
		{
			get
			{
				if (_fastTravelPointData == null)
				{
					_fastTravelPointData = (CHandle<gameFastTravelPointData>) CR2WTypeManager.Create("handle:gameFastTravelPointData", "fastTravelPointData", cr2w, this);
				}
				return _fastTravelPointData;
			}
			set
			{
				if (_fastTravelPointData == value)
				{
					return;
				}
				_fastTravelPointData = value;
				PropertySet(this);
			}
		}

		public FastTravelDeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
