using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseResaveData : CVariable
	{
		private BaseDeviceData _baseDeviceData;
		private TweakDBID _tweakDBRecord;

		[Ordinal(0)] 
		[RED("baseDeviceData")] 
		public BaseDeviceData BaseDeviceData
		{
			get => GetProperty(ref _baseDeviceData);
			set => SetProperty(ref _baseDeviceData, value);
		}

		[Ordinal(1)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get => GetProperty(ref _tweakDBRecord);
			set => SetProperty(ref _tweakDBRecord, value);
		}

		public BaseResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
