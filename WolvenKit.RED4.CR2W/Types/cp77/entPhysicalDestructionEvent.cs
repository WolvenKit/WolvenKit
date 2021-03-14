using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalDestructionEvent : redEvent
	{
		private CName _componentName;
		private CUInt8 _levelOfDestruction;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("levelOfDestruction")] 
		public CUInt8 LevelOfDestruction
		{
			get
			{
				if (_levelOfDestruction == null)
				{
					_levelOfDestruction = (CUInt8) CR2WTypeManager.Create("Uint8", "levelOfDestruction", cr2w, this);
				}
				return _levelOfDestruction;
			}
			set
			{
				if (_levelOfDestruction == value)
				{
					return;
				}
				_levelOfDestruction = value;
				PropertySet(this);
			}
		}

		public entPhysicalDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
