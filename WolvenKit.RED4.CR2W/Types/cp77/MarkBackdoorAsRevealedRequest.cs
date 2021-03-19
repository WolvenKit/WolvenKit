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
			get => GetProperty(ref _device);
			set => SetProperty(ref _device, value);
		}

		public MarkBackdoorAsRevealedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
