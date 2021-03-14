using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledCrowdData : ISerializable
	{
		private CArray<gameCrowdTrafficDataPackage> _trafficDataPackages;

		[Ordinal(0)] 
		[RED("trafficDataPackages")] 
		public CArray<gameCrowdTrafficDataPackage> TrafficDataPackages
		{
			get
			{
				if (_trafficDataPackages == null)
				{
					_trafficDataPackages = (CArray<gameCrowdTrafficDataPackage>) CR2WTypeManager.Create("array:gameCrowdTrafficDataPackage", "trafficDataPackages", cr2w, this);
				}
				return _trafficDataPackages;
			}
			set
			{
				if (_trafficDataPackages == value)
				{
					return;
				}
				_trafficDataPackages = value;
				PropertySet(this);
			}
		}

		public gameCompiledCrowdData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
