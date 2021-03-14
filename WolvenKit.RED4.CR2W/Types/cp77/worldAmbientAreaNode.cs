using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAmbientAreaNode : worldTriggerAreaNode
	{
		private CBool _useCustomColor;

		[Ordinal(7)] 
		[RED("useCustomColor")] 
		public CBool UseCustomColor
		{
			get
			{
				if (_useCustomColor == null)
				{
					_useCustomColor = (CBool) CR2WTypeManager.Create("Bool", "useCustomColor", cr2w, this);
				}
				return _useCustomColor;
			}
			set
			{
				if (_useCustomColor == value)
				{
					return;
				}
				_useCustomColor = value;
				PropertySet(this);
			}
		}

		public worldAmbientAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
