using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponStats : animAnimFeature
	{
		private CInt32 _magazineCapacity;
		private CFloat _cycleTime;

		[Ordinal(0)] 
		[RED("magazineCapacity")] 
		public CInt32 MagazineCapacity
		{
			get
			{
				if (_magazineCapacity == null)
				{
					_magazineCapacity = (CInt32) CR2WTypeManager.Create("Int32", "magazineCapacity", cr2w, this);
				}
				return _magazineCapacity;
			}
			set
			{
				if (_magazineCapacity == value)
				{
					return;
				}
				_magazineCapacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get
			{
				if (_cycleTime == null)
				{
					_cycleTime = (CFloat) CR2WTypeManager.Create("Float", "cycleTime", cr2w, this);
				}
				return _cycleTime;
			}
			set
			{
				if (_cycleTime == value)
				{
					return;
				}
				_cycleTime = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WeaponStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
