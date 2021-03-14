using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetDebugView_NodeType : questIRenderFxManagerNodeType
	{
		private CEnum<questEDebugViewMode> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questEDebugViewMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questEDebugViewMode>) CR2WTypeManager.Create("questEDebugViewMode", "mode", cr2w, this);
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

		public questSetDebugView_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
