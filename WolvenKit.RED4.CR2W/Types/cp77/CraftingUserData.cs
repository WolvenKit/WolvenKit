using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingUserData : IScriptable
	{
		private CEnum<CraftingMode> _mode;

		[Ordinal(0)] 
		[RED("Mode")] 
		public CEnum<CraftingMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<CraftingMode>) CR2WTypeManager.Create("CraftingMode", "Mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public CraftingUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
