using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceDynObjectLogic : gameuiSideScrollerMiniGameDynObjectLogic
	{
		private CFloat _minSpawnY;
		private CFloat _maxSpawnY;
		private CFloat _extraSpeed;
		private CArray<CFloat> _availableY;

		[Ordinal(2)] 
		[RED("minSpawnY")] 
		public CFloat MinSpawnY
		{
			get
			{
				if (_minSpawnY == null)
				{
					_minSpawnY = (CFloat) CR2WTypeManager.Create("Float", "minSpawnY", cr2w, this);
				}
				return _minSpawnY;
			}
			set
			{
				if (_minSpawnY == value)
				{
					return;
				}
				_minSpawnY = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxSpawnY")] 
		public CFloat MaxSpawnY
		{
			get
			{
				if (_maxSpawnY == null)
				{
					_maxSpawnY = (CFloat) CR2WTypeManager.Create("Float", "maxSpawnY", cr2w, this);
				}
				return _maxSpawnY;
			}
			set
			{
				if (_maxSpawnY == value)
				{
					return;
				}
				_maxSpawnY = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("extraSpeed")] 
		public CFloat ExtraSpeed
		{
			get
			{
				if (_extraSpeed == null)
				{
					_extraSpeed = (CFloat) CR2WTypeManager.Create("Float", "extraSpeed", cr2w, this);
				}
				return _extraSpeed;
			}
			set
			{
				if (_extraSpeed == value)
				{
					return;
				}
				_extraSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("availableY")] 
		public CArray<CFloat> AvailableY
		{
			get
			{
				if (_availableY == null)
				{
					_availableY = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "availableY", cr2w, this);
				}
				return _availableY;
			}
			set
			{
				if (_availableY == value)
				{
					return;
				}
				_availableY = value;
				PropertySet(this);
			}
		}

		public gameuiRoachRaceDynObjectLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
