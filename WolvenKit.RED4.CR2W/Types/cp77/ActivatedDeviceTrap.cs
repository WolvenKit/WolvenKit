using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrap : ActivatedDeviceTransfromAnim
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;

		[Ordinal(97)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		public ActivatedDeviceTrap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
