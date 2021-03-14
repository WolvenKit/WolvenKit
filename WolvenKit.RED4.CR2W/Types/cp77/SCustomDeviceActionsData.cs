using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCustomDeviceActionsData : CVariable
	{
		private CArray<SDeviceActionCustomData> _actions;

		[Ordinal(0)] 
		[RED("actions")] 
		public CArray<SDeviceActionCustomData> Actions
		{
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<SDeviceActionCustomData>) CR2WTypeManager.Create("array:SDeviceActionCustomData", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		public SCustomDeviceActionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
