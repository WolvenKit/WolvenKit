using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetupEntry : CVariable
	{
		private CUInt8 _priority;
		private raRef<animAnimSet> _animSet;
		private CArray<CName> _variableNames;

		[Ordinal(0)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt8) CR2WTypeManager.Create("Uint8", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animSet")] 
		public raRef<animAnimSet> AnimSet
		{
			get
			{
				if (_animSet == null)
				{
					_animSet = (raRef<animAnimSet>) CR2WTypeManager.Create("raRef:animAnimSet", "animSet", cr2w, this);
				}
				return _animSet;
			}
			set
			{
				if (_animSet == value)
				{
					return;
				}
				_animSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variableNames")] 
		public CArray<CName> VariableNames
		{
			get
			{
				if (_variableNames == null)
				{
					_variableNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "variableNames", cr2w, this);
				}
				return _variableNames;
			}
			set
			{
				if (_variableNames == value)
				{
					return;
				}
				_variableNames = value;
				PropertySet(this);
			}
		}

		public animAnimSetupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
