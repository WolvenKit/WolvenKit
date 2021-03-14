using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointTerminalInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _sellAction;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("sellAction")] 
		public inkWidgetReference SellAction
		{
			get
			{
				if (_sellAction == null)
				{
					_sellAction = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sellAction", cr2w, this);
				}
				return _sellAction;
			}
			set
			{
				if (_sellAction == value)
				{
					return;
				}
				_sellAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get
			{
				if (_onGlitchingStateChangedListener == null)
				{
					_onGlitchingStateChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingStateChangedListener", cr2w, this);
				}
				return _onGlitchingStateChangedListener;
			}
			set
			{
				if (_onGlitchingStateChangedListener == value)
				{
					return;
				}
				_onGlitchingStateChangedListener = value;
				PropertySet(this);
			}
		}

		public DropPointTerminalInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
