using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarkBackdoorAsRevealedRequest : gameScriptableSystemRequest
	{
		private CHandle<SharedGameplayPS> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public CHandle<SharedGameplayPS> Device
		{
			get
			{
				if (_device == null)
				{
					_device = (CHandle<SharedGameplayPS>) CR2WTypeManager.Create("handle:SharedGameplayPS", "device", cr2w, this);
				}
				return _device;
			}
			set
			{
				if (_device == value)
				{
					return;
				}
				_device = value;
				PropertySet(this);
			}
		}

		public MarkBackdoorAsRevealedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
