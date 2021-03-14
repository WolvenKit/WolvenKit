using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleNPCDeathData : animAnimFeature
	{
		private CInt32 _deathType;
		private CInt32 _side;

		[Ordinal(0)] 
		[RED("deathType")] 
		public CInt32 DeathType
		{
			get
			{
				if (_deathType == null)
				{
					_deathType = (CInt32) CR2WTypeManager.Create("Int32", "deathType", cr2w, this);
				}
				return _deathType;
			}
			set
			{
				if (_deathType == value)
				{
					return;
				}
				_deathType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get
			{
				if (_side == null)
				{
					_side = (CInt32) CR2WTypeManager.Create("Int32", "side", cr2w, this);
				}
				return _side;
			}
			set
			{
				if (_side == value)
				{
					return;
				}
				_side = value;
				PropertySet(this);
			}
		}

		public AnimFeature_VehicleNPCDeathData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
