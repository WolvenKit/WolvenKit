using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrap : ActivatedDeviceTransfromAnim
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;

		[Ordinal(94)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get
			{
				if (_areaComponent == null)
				{
					_areaComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "areaComponent", cr2w, this);
				}
				return _areaComponent;
			}
			set
			{
				if (_areaComponent == value)
				{
					return;
				}
				_areaComponent = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceTrap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
