using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderScanEvent : redEvent
	{
		private CEnum<rendPostFx_ScanningState> _scanState;

		[Ordinal(0)] 
		[RED("scanState")] 
		public CEnum<rendPostFx_ScanningState> ScanState
		{
			get
			{
				if (_scanState == null)
				{
					_scanState = (CEnum<rendPostFx_ScanningState>) CR2WTypeManager.Create("rendPostFx_ScanningState", "scanState", cr2w, this);
				}
				return _scanState;
			}
			set
			{
				if (_scanState == value)
				{
					return;
				}
				_scanState = value;
				PropertySet(this);
			}
		}

		public entRenderScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
