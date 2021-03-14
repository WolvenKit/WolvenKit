using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShaftsAreaSettings : CVariable
	{
		private CUInt32 _shaftsLevelIndex;
		private CFloat _shaftsIntensity;
		private CFloat _shaftsThresholdsScale;

		[Ordinal(0)] 
		[RED("shaftsLevelIndex")] 
		public CUInt32 ShaftsLevelIndex
		{
			get
			{
				if (_shaftsLevelIndex == null)
				{
					_shaftsLevelIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "shaftsLevelIndex", cr2w, this);
				}
				return _shaftsLevelIndex;
			}
			set
			{
				if (_shaftsLevelIndex == value)
				{
					return;
				}
				_shaftsLevelIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shaftsIntensity")] 
		public CFloat ShaftsIntensity
		{
			get
			{
				if (_shaftsIntensity == null)
				{
					_shaftsIntensity = (CFloat) CR2WTypeManager.Create("Float", "shaftsIntensity", cr2w, this);
				}
				return _shaftsIntensity;
			}
			set
			{
				if (_shaftsIntensity == value)
				{
					return;
				}
				_shaftsIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shaftsThresholdsScale")] 
		public CFloat ShaftsThresholdsScale
		{
			get
			{
				if (_shaftsThresholdsScale == null)
				{
					_shaftsThresholdsScale = (CFloat) CR2WTypeManager.Create("Float", "shaftsThresholdsScale", cr2w, this);
				}
				return _shaftsThresholdsScale;
			}
			set
			{
				if (_shaftsThresholdsScale == value)
				{
					return;
				}
				_shaftsThresholdsScale = value;
				PropertySet(this);
			}
		}

		public ShaftsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
