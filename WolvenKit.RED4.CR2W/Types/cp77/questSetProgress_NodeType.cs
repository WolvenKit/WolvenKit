using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetProgress_NodeType : questIAchievementManagerNodeType
	{
		private TweakDBID _achievement;
		private CString _factName;
		private CUInt32 _maxValue;
		private CUInt32 _currentValue;

		[Ordinal(0)] 
		[RED("achievement")] 
		public TweakDBID Achievement
		{
			get
			{
				if (_achievement == null)
				{
					_achievement = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "achievement", cr2w, this);
				}
				return _achievement;
			}
			set
			{
				if (_achievement == value)
				{
					return;
				}
				_achievement = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CString FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CString) CR2WTypeManager.Create("String", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CUInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CUInt32) CR2WTypeManager.Create("Uint32", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentValue")] 
		public CUInt32 CurrentValue
		{
			get
			{
				if (_currentValue == null)
				{
					_currentValue = (CUInt32) CR2WTypeManager.Create("Uint32", "currentValue", cr2w, this);
				}
				return _currentValue;
			}
			set
			{
				if (_currentValue == value)
				{
					return;
				}
				_currentValue = value;
				PropertySet(this);
			}
		}

		public questSetProgress_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
