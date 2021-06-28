using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaResaveData : CVariable
	{
		private MediaDeviceData _mediaDeviceData;

		[Ordinal(0)] 
		[RED("mediaDeviceData")] 
		public MediaDeviceData MediaDeviceData
		{
			get => GetProperty(ref _mediaDeviceData);
			set => SetProperty(ref _mediaDeviceData, value);
		}

		public MediaResaveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
