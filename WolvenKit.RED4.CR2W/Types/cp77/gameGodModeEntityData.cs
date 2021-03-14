using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeEntityData : CVariable
	{
		private CArray<gameGodModeData> _overrides;
		private CArray<gameGodModeData> _base;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<gameGodModeData> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CArray<gameGodModeData>) CR2WTypeManager.Create("array:gameGodModeData", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("base")] 
		public CArray<gameGodModeData> Base
		{
			get
			{
				if (_base == null)
				{
					_base = (CArray<gameGodModeData>) CR2WTypeManager.Create("array:gameGodModeData", "base", cr2w, this);
				}
				return _base;
			}
			set
			{
				if (_base == value)
				{
					return;
				}
				_base = value;
				PropertySet(this);
			}
		}

		public gameGodModeEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
