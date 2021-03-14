using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseToggleView : inkWidgetLogicController
	{
		private wCHandle<inkToggleController> _toggleController;
		private CEnum<inkEToggleState> _oldState;

		[Ordinal(1)] 
		[RED("ToggleController")] 
		public wCHandle<inkToggleController> ToggleController
		{
			get
			{
				if (_toggleController == null)
				{
					_toggleController = (wCHandle<inkToggleController>) CR2WTypeManager.Create("whandle:inkToggleController", "ToggleController", cr2w, this);
				}
				return _toggleController;
			}
			set
			{
				if (_toggleController == value)
				{
					return;
				}
				_toggleController = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("OldState")] 
		public CEnum<inkEToggleState> OldState
		{
			get
			{
				if (_oldState == null)
				{
					_oldState = (CEnum<inkEToggleState>) CR2WTypeManager.Create("inkEToggleState", "OldState", cr2w, this);
				}
				return _oldState;
			}
			set
			{
				if (_oldState == value)
				{
					return;
				}
				_oldState = value;
				PropertySet(this);
			}
		}

		public BaseToggleView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
